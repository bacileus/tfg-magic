grammar SpellCreator;

///// PARSER RULES /////
// SPELL
spell: element shape EOF?;

// ELEMENTS
element: (fire | ice | shock) effect;
fire: FIRESOME;
ice: FROZEN;
shock: STORMFUL;

// EFFECTS
effect: (life | resistance | speed);
life: WISE? ADJECTIVE? ADJECTIVE? LIFE SIGN;
resistance: WISE? ADJECTIVE? ADJECTIVE? RESISTANCE SIGN;
speed: WISE? ADJECTIVE? ADJECTIVE? SPEED SIGN;

// SHAPES
shape: connector (projectile | area | self) demeanour? impact?;
projectile: ADJECTIVE? PROJECTILE;
area: ADJECTIVE? AREA;
self: SELF;

// DEMEANOURS
demeanour: connector (instant | impulse | chase | fall | parent);
instant: INSTANT;
impulse: ADJECTIVE? IMPULSE;
chase: ADJECTIVE? CHASE;
fall: ADJECTIVE? FALL;
parent: PARENT;

// IMPACTS
impact: connector (destroy | ricochet | multiple);
destroy: ADJECTIVE? DESTROY;
ricochet: ADJECTIVE? RICOCHET;
multiple: ADJECTIVE? MULTIPLE;

// OTHER
connector: CONNECTOR;

///// LEXER RULES /////
// ELEMENTS
FIRESOME: 'FIRESOME';
FROZEN: 'FROZEN';
STORMFUL: 'STORMFUL';

// EFFECTS
LIFE: 'LIFE';
RESISTANCE: 'RESISTANCE';
SPEED: 'SPEED';

// SHAPES
PROJECTILE: 'PROJECTILE';
AREA: 'AREA';
SELF: 'SELF';

// DEMEANOURS
INSTANT: 'INSTANT';
IMPULSE: 'IMPULSE';
CHASE: 'CHASE';
FALL: 'FALL';
PARENT: 'PARENT';

// IMPACTS
DESTROY: 'DESTROY';
RICOCHET: 'RICOCHET';
MULTIPLE: 'MULTIPLE';

// ADJECTIVES
fragment SMALL: ('PITTY' | 'TINY' | 'SPARKING' | 'WALKING');
fragment MEDIUM: ('COMMON' | 'LARGE' | 'ENDURING' | 'RUNNING');
fragment LARGE: ('GREAT' | 'MAJESTIC' | 'EVERLASTING' | 'FLYING');
ADJECTIVE: (SMALL | MEDIUM | LARGE);

// MAGNITUDE SIGN
fragment BUFF: 'BUFF';
fragment DEBUFF: 'DEBUFF';
SIGN: (BUFF | DEBUFF);

// AFFECTS CASTER?
WISE: 'WISE';

// NON FUNCTIONAL
WS: [ \t\r\n] -> skip;
CONNECTOR: ('IN' | 'AS' | 'AND');