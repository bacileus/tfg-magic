using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

public class SpellCaster : MonoBehaviour
{
    private Dictionary<string, Spell> grimoire;
    private Dictionary<string, string> spellList;

    void Awake() {
        grimoire = new Dictionary<string, Spell>();
        spellList = new Dictionary<string, string>() {
            { "ONE", "FIRESOME GREAT LIFE DEBUFF IN PITTY PROJECTILE AS CHASE AND PITTY DESTROY" },
            { "TWO", "STORMFUL GREAT LIFE BUFF IN SELF" },
            { "THREE", "FROZEN RESISTANCE DEBUFF IN AREA AS PARENT" },
            { "FOUR", "FROZEN EVERLASITNG SPEED BUFF IN SELF" },
            { "FIVE", "FIRESOME WISE RESISTANCE DEBUFF IN AREA AS INSTANT" }
        };
    }

    private void buildSpell(string phrase)
    {
        // AntlrInputStream stream = new AntlrInputStream(input);
        ICharStream stream = CharStreams.fromString(phrase);
        ITokenSource lexer = new SpellCreatorLexer(stream);
        ITokenStream tokens = new CommonTokenStream(lexer);
        SpellCreatorParser parser = new SpellCreatorParser(tokens);
        IParseTree tree = parser.spell();

        SpellCreator spellCreator = new SpellCreator();
        ParseTreeWalker walker = new ParseTreeWalker();
        walker.Walk(spellCreator, tree);

        grimoire.Add(phrase, spellCreator.getSpell());
    }

    public void castSpell(string key) /* ONE, TWO, ETC. */
    {
        // Instancia gameobjects
        // Els posa components basats en el Spell
        string phrase = spellList[key];
        if(!grimoire.ContainsKey(phrase)) buildSpell(phrase);
        
        Spell spell = grimoire[phrase];
        Shape shape = spell.getShape();
        ParticleSystem ps = Instantiate(shape.getShapeDef().getParticleSystem(), transform.position, transform.rotation);
        ConfigSpell cs = ps.gameObject.AddComponent<ConfigSpell>();
        cs.setConfigSpell(spell, transform.parent);
    }
}
