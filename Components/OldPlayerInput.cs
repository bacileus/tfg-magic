using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using PDollarGestureRecognizer;
using System;

public class OldPlayerInput : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // MOVEMENT
    [SerializeField] private ParticleMarker markerHelper;
    [SerializeField] private LayerMask terrainMask;
    private MovementReceiver movementReceiver;
    // DRAWING
    [SerializeField] private GameObject trailGameObject;
    private DrawState drawState;
    private TrailRenderer trailRenderer;
    private List<Point> trailPoints;

    enum DrawState {
        None,
        Active,
        Drawing
    }
    
    // Start is called before the first frame update
    void Start()
    {
        movementReceiver = player.GetComponent<MovementReceiver>();
        markerHelper = markerHelper.GetComponent<ParticleMarker>();
        drawState = DrawState.None;
        trailRenderer = trailGameObject.GetComponent<TrailRenderer>();
        trailPoints = new List<Point>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 || Input.GetMouseButton(0)) {
            Touch touch;
            /*
            if (Application.platform == RuntimePlatform.WindowsEditor) {
                touch = getTouchFromMouse();
            } else touch = Input.GetTouch(0);
            */
            touch = Input.GetTouch(0);
            if(drawState == DrawState.None) {
                // MOVEMENT
                if(touch.phase != TouchPhase.Ended && !EventSystem.current.IsPointerOverGameObject(touch.fingerId)) {                
                    Ray r = Camera.main.ScreenPointToRay(touch.position);
                    RaycastHit hit;
                    if(Physics.Raycast(r, out hit, 100, terrainMask)) {
                        if(movementReceiver.move(hit.point))
                            markerHelper.move(hit.point);
                    }
                }
            } else {
                // SPELL DRAWING
                if((drawState == DrawState.Active || drawState == DrawState.Drawing) && touch.phase == TouchPhase.Moved) {
                    // el jugador esta dibujando
                    drawState = DrawState.Drawing;
                    trailRenderer.emitting = true;

                    Plane plane = new Plane(Camera.main.transform.forward*-1, trailGameObject.transform.position);
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);
                    float ray_distance;
                    if(plane.Raycast(ray, out ray_distance))
                        trailGameObject.transform.position = ray.GetPoint(ray_distance);

                    // añadimos punto a la lista (por ingeniería inversa, la y es negativa)
                    trailPoints.Add(new Point(touch.position.x, -touch.position.y, 0));
                }

                if(drawState == DrawState.Drawing && touch.phase == TouchPhase.Ended) {
                    // una vez hemos finalizado el dibujo, llamamos al
                    // reconocedor para que haga el trabajo de descifrar
                    RuneRecognizer.instance.recognize(trailPoints);
                    trailPoints.Clear();
                    // clear data
                    drawState = DrawState.None;
                    trailRenderer.emitting = false;
                    trailRenderer.Clear();
                }
            }
        }

        // Fix initial displacement - it just works :)
        Vector3 aux = Input.mousePosition;
        aux.z = 5;
        trailGameObject.transform.position = Camera.main.ScreenToWorldPoint(aux);    
    }

    // función que crea un touch a partir de Mouse 0
    private Touch getTouchFromMouse()
    {
        Touch touch = new Touch();

        touch.fingerId = -1;
        touch.position = Input.mousePosition;

        if (Input.GetMouseButtonDown(0)) touch.phase = TouchPhase.Began;
        else if(Input.GetMouseButtonUp(0)) touch.phase = TouchPhase.Ended;
        else if(Input.GetAxis("Mouse X") > 0 && Input.GetAxis("Mouse Y") > 0) touch.phase = TouchPhase.Moved;
        else touch.phase = TouchPhase.Stationary;

        return touch;
    }

    public void activateDraw() {
        drawState = DrawState.Active;
    }
}
