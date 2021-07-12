//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\SpellCreator.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public partial class SpellCreatorLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		FIRESOME=1, FROZEN=2, STORMFUL=3, LIFE=4, RESISTANCE=5, SPEED=6, PROJECTILE=7, 
		AREA=8, SELF=9, INSTANT=10, IMPULSE=11, CHASE=12, FALL=13, PARENT=14, 
		DESTROY=15, RICOCHET=16, MULTIPLE=17, ADJECTIVE=18, SIGN=19, WISE=20, 
		WS=21, CONNECTOR=22;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"FIRESOME", "FROZEN", "STORMFUL", "LIFE", "RESISTANCE", "SPEED", "PROJECTILE", 
		"AREA", "SELF", "INSTANT", "IMPULSE", "CHASE", "FALL", "PARENT", "DESTROY", 
		"RICOCHET", "MULTIPLE", "SMALL", "MEDIUM", "LARGE", "ADJECTIVE", "BUFF", 
		"DEBUFF", "SIGN", "WISE", "WS", "CONNECTOR"
	};


	public SpellCreatorLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public SpellCreatorLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'FIRESOME'", "'FROZEN'", "'STORMFUL'", "'LIFE'", "'RESISTANCE'", 
		"'SPEED'", "'PROJECTILE'", "'AREA'", "'SELF'", "'INSTANT'", "'IMPULSE'", 
		"'CHASE'", "'FALL'", "'PARENT'", "'DESTROY'", "'RICOCHET'", "'MULTIPLE'", 
		null, null, "'WISE'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "FIRESOME", "FROZEN", "STORMFUL", "LIFE", "RESISTANCE", "SPEED", 
		"PROJECTILE", "AREA", "SELF", "INSTANT", "IMPULSE", "CHASE", "FALL", "PARENT", 
		"DESTROY", "RICOCHET", "MULTIPLE", "ADJECTIVE", "SIGN", "WISE", "WS", 
		"CONNECTOR"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "SpellCreator.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static SpellCreatorLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x18', '\x136', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x13', '\x5', '\x13', '\xD2', '\n', '\x13', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x5', 
		'\x14', '\xEE', '\n', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x15', '\x5', '\x15', '\x10E', '\n', '\x15', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x5', '\x16', '\x113', '\n', '\x16', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x5', '\x19', 
		'\x123', '\n', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x5', '\x1C', '\x135', '\n', '\x1C', 
		'\x2', '\x2', '\x1D', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', 
		'\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', 
		'\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', 
		'\x11', '!', '\x12', '#', '\x13', '%', '\x2', '\'', '\x2', ')', '\x2', 
		'+', '\x14', '-', '\x2', '/', '\x2', '\x31', '\x15', '\x33', '\x16', '\x35', 
		'\x17', '\x37', '\x18', '\x3', '\x2', '\x3', '\x5', '\x2', '\v', '\f', 
		'\xF', '\xF', '\"', '\"', '\x2', '\x13E', '\x2', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x31', '\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', 
		'\x2', '\x2', '\x2', '\x3', '\x39', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\a', 'I', '\x3', '\x2', '\x2', '\x2', 
		'\t', 'R', '\x3', '\x2', '\x2', '\x2', '\v', 'W', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\x62', '\x3', '\x2', '\x2', '\x2', '\xF', 'h', '\x3', '\x2', 
		'\x2', '\x2', '\x11', 's', '\x3', '\x2', '\x2', '\x2', '\x13', 'x', '\x3', 
		'\x2', '\x2', '\x2', '\x15', '}', '\x3', '\x2', '\x2', '\x2', '\x17', 
		'\x85', '\x3', '\x2', '\x2', '\x2', '\x19', '\x8D', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\x93', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x98', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', '\x9F', '\x3', '\x2', '\x2', '\x2', '!', 
		'\xA7', '\x3', '\x2', '\x2', '\x2', '#', '\xB0', '\x3', '\x2', '\x2', 
		'\x2', '%', '\xD1', '\x3', '\x2', '\x2', '\x2', '\'', '\xED', '\x3', '\x2', 
		'\x2', '\x2', ')', '\x10D', '\x3', '\x2', '\x2', '\x2', '+', '\x112', 
		'\x3', '\x2', '\x2', '\x2', '-', '\x114', '\x3', '\x2', '\x2', '\x2', 
		'/', '\x119', '\x3', '\x2', '\x2', '\x2', '\x31', '\x122', '\x3', '\x2', 
		'\x2', '\x2', '\x33', '\x124', '\x3', '\x2', '\x2', '\x2', '\x35', '\x129', 
		'\x3', '\x2', '\x2', '\x2', '\x37', '\x134', '\x3', '\x2', '\x2', '\x2', 
		'\x39', ':', '\a', 'H', '\x2', '\x2', ':', ';', '\a', 'K', '\x2', '\x2', 
		';', '<', '\a', 'T', '\x2', '\x2', '<', '=', '\a', 'G', '\x2', '\x2', 
		'=', '>', '\a', 'U', '\x2', '\x2', '>', '?', '\a', 'Q', '\x2', '\x2', 
		'?', '@', '\a', 'O', '\x2', '\x2', '@', '\x41', '\a', 'G', '\x2', '\x2', 
		'\x41', '\x4', '\x3', '\x2', '\x2', '\x2', '\x42', '\x43', '\a', 'H', 
		'\x2', '\x2', '\x43', '\x44', '\a', 'T', '\x2', '\x2', '\x44', '\x45', 
		'\a', 'Q', '\x2', '\x2', '\x45', '\x46', '\a', '\\', '\x2', '\x2', '\x46', 
		'G', '\a', 'G', '\x2', '\x2', 'G', 'H', '\a', 'P', '\x2', '\x2', 'H', 
		'\x6', '\x3', '\x2', '\x2', '\x2', 'I', 'J', '\a', 'U', '\x2', '\x2', 
		'J', 'K', '\a', 'V', '\x2', '\x2', 'K', 'L', '\a', 'Q', '\x2', '\x2', 
		'L', 'M', '\a', 'T', '\x2', '\x2', 'M', 'N', '\a', 'O', '\x2', '\x2', 
		'N', 'O', '\a', 'H', '\x2', '\x2', 'O', 'P', '\a', 'W', '\x2', '\x2', 
		'P', 'Q', '\a', 'N', '\x2', '\x2', 'Q', '\b', '\x3', '\x2', '\x2', '\x2', 
		'R', 'S', '\a', 'N', '\x2', '\x2', 'S', 'T', '\a', 'K', '\x2', '\x2', 
		'T', 'U', '\a', 'H', '\x2', '\x2', 'U', 'V', '\a', 'G', '\x2', '\x2', 
		'V', '\n', '\x3', '\x2', '\x2', '\x2', 'W', 'X', '\a', 'T', '\x2', '\x2', 
		'X', 'Y', '\a', 'G', '\x2', '\x2', 'Y', 'Z', '\a', 'U', '\x2', '\x2', 
		'Z', '[', '\a', 'K', '\x2', '\x2', '[', '\\', '\a', 'U', '\x2', '\x2', 
		'\\', ']', '\a', 'V', '\x2', '\x2', ']', '^', '\a', '\x43', '\x2', '\x2', 
		'^', '_', '\a', 'P', '\x2', '\x2', '_', '`', '\a', '\x45', '\x2', '\x2', 
		'`', '\x61', '\a', 'G', '\x2', '\x2', '\x61', '\f', '\x3', '\x2', '\x2', 
		'\x2', '\x62', '\x63', '\a', 'U', '\x2', '\x2', '\x63', '\x64', '\a', 
		'R', '\x2', '\x2', '\x64', '\x65', '\a', 'G', '\x2', '\x2', '\x65', '\x66', 
		'\a', 'G', '\x2', '\x2', '\x66', 'g', '\a', '\x46', '\x2', '\x2', 'g', 
		'\xE', '\x3', '\x2', '\x2', '\x2', 'h', 'i', '\a', 'R', '\x2', '\x2', 
		'i', 'j', '\a', 'T', '\x2', '\x2', 'j', 'k', '\a', 'Q', '\x2', '\x2', 
		'k', 'l', '\a', 'L', '\x2', '\x2', 'l', 'm', '\a', 'G', '\x2', '\x2', 
		'm', 'n', '\a', '\x45', '\x2', '\x2', 'n', 'o', '\a', 'V', '\x2', '\x2', 
		'o', 'p', '\a', 'K', '\x2', '\x2', 'p', 'q', '\a', 'N', '\x2', '\x2', 
		'q', 'r', '\a', 'G', '\x2', '\x2', 'r', '\x10', '\x3', '\x2', '\x2', '\x2', 
		's', 't', '\a', '\x43', '\x2', '\x2', 't', 'u', '\a', 'T', '\x2', '\x2', 
		'u', 'v', '\a', 'G', '\x2', '\x2', 'v', 'w', '\a', '\x43', '\x2', '\x2', 
		'w', '\x12', '\x3', '\x2', '\x2', '\x2', 'x', 'y', '\a', 'U', '\x2', '\x2', 
		'y', 'z', '\a', 'G', '\x2', '\x2', 'z', '{', '\a', 'N', '\x2', '\x2', 
		'{', '|', '\a', 'H', '\x2', '\x2', '|', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'}', '~', '\a', 'K', '\x2', '\x2', '~', '\x7F', '\a', 'P', '\x2', '\x2', 
		'\x7F', '\x80', '\a', 'U', '\x2', '\x2', '\x80', '\x81', '\a', 'V', '\x2', 
		'\x2', '\x81', '\x82', '\a', '\x43', '\x2', '\x2', '\x82', '\x83', '\a', 
		'P', '\x2', '\x2', '\x83', '\x84', '\a', 'V', '\x2', '\x2', '\x84', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\a', 'K', '\x2', '\x2', '\x86', 
		'\x87', '\a', 'O', '\x2', '\x2', '\x87', '\x88', '\a', 'R', '\x2', '\x2', 
		'\x88', '\x89', '\a', 'W', '\x2', '\x2', '\x89', '\x8A', '\a', 'N', '\x2', 
		'\x2', '\x8A', '\x8B', '\a', 'U', '\x2', '\x2', '\x8B', '\x8C', '\a', 
		'G', '\x2', '\x2', '\x8C', '\x18', '\x3', '\x2', '\x2', '\x2', '\x8D', 
		'\x8E', '\a', '\x45', '\x2', '\x2', '\x8E', '\x8F', '\a', 'J', '\x2', 
		'\x2', '\x8F', '\x90', '\a', '\x43', '\x2', '\x2', '\x90', '\x91', '\a', 
		'U', '\x2', '\x2', '\x91', '\x92', '\a', 'G', '\x2', '\x2', '\x92', '\x1A', 
		'\x3', '\x2', '\x2', '\x2', '\x93', '\x94', '\a', 'H', '\x2', '\x2', '\x94', 
		'\x95', '\a', '\x43', '\x2', '\x2', '\x95', '\x96', '\a', 'N', '\x2', 
		'\x2', '\x96', '\x97', '\a', 'N', '\x2', '\x2', '\x97', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', '\x98', '\x99', '\a', 'R', '\x2', '\x2', '\x99', 
		'\x9A', '\a', '\x43', '\x2', '\x2', '\x9A', '\x9B', '\a', 'T', '\x2', 
		'\x2', '\x9B', '\x9C', '\a', 'G', '\x2', '\x2', '\x9C', '\x9D', '\a', 
		'P', '\x2', '\x2', '\x9D', '\x9E', '\a', 'V', '\x2', '\x2', '\x9E', '\x1E', 
		'\x3', '\x2', '\x2', '\x2', '\x9F', '\xA0', '\a', '\x46', '\x2', '\x2', 
		'\xA0', '\xA1', '\a', 'G', '\x2', '\x2', '\xA1', '\xA2', '\a', 'U', '\x2', 
		'\x2', '\xA2', '\xA3', '\a', 'V', '\x2', '\x2', '\xA3', '\xA4', '\a', 
		'T', '\x2', '\x2', '\xA4', '\xA5', '\a', 'Q', '\x2', '\x2', '\xA5', '\xA6', 
		'\a', '[', '\x2', '\x2', '\xA6', ' ', '\x3', '\x2', '\x2', '\x2', '\xA7', 
		'\xA8', '\a', 'T', '\x2', '\x2', '\xA8', '\xA9', '\a', 'K', '\x2', '\x2', 
		'\xA9', '\xAA', '\a', '\x45', '\x2', '\x2', '\xAA', '\xAB', '\a', 'Q', 
		'\x2', '\x2', '\xAB', '\xAC', '\a', '\x45', '\x2', '\x2', '\xAC', '\xAD', 
		'\a', 'J', '\x2', '\x2', '\xAD', '\xAE', '\a', 'G', '\x2', '\x2', '\xAE', 
		'\xAF', '\a', 'V', '\x2', '\x2', '\xAF', '\"', '\x3', '\x2', '\x2', '\x2', 
		'\xB0', '\xB1', '\a', 'O', '\x2', '\x2', '\xB1', '\xB2', '\a', 'W', '\x2', 
		'\x2', '\xB2', '\xB3', '\a', 'N', '\x2', '\x2', '\xB3', '\xB4', '\a', 
		'V', '\x2', '\x2', '\xB4', '\xB5', '\a', 'K', '\x2', '\x2', '\xB5', '\xB6', 
		'\a', 'R', '\x2', '\x2', '\xB6', '\xB7', '\a', 'N', '\x2', '\x2', '\xB7', 
		'\xB8', '\a', 'G', '\x2', '\x2', '\xB8', '$', '\x3', '\x2', '\x2', '\x2', 
		'\xB9', '\xBA', '\a', 'R', '\x2', '\x2', '\xBA', '\xBB', '\a', 'K', '\x2', 
		'\x2', '\xBB', '\xBC', '\a', 'V', '\x2', '\x2', '\xBC', '\xBD', '\a', 
		'V', '\x2', '\x2', '\xBD', '\xD2', '\a', '[', '\x2', '\x2', '\xBE', '\xBF', 
		'\a', 'V', '\x2', '\x2', '\xBF', '\xC0', '\a', 'K', '\x2', '\x2', '\xC0', 
		'\xC1', '\a', 'P', '\x2', '\x2', '\xC1', '\xD2', '\a', '[', '\x2', '\x2', 
		'\xC2', '\xC3', '\a', 'U', '\x2', '\x2', '\xC3', '\xC4', '\a', 'R', '\x2', 
		'\x2', '\xC4', '\xC5', '\a', '\x43', '\x2', '\x2', '\xC5', '\xC6', '\a', 
		'T', '\x2', '\x2', '\xC6', '\xC7', '\a', 'M', '\x2', '\x2', '\xC7', '\xC8', 
		'\a', 'K', '\x2', '\x2', '\xC8', '\xC9', '\a', 'P', '\x2', '\x2', '\xC9', 
		'\xD2', '\a', 'I', '\x2', '\x2', '\xCA', '\xCB', '\a', 'Y', '\x2', '\x2', 
		'\xCB', '\xCC', '\a', '\x43', '\x2', '\x2', '\xCC', '\xCD', '\a', 'N', 
		'\x2', '\x2', '\xCD', '\xCE', '\a', 'M', '\x2', '\x2', '\xCE', '\xCF', 
		'\a', 'K', '\x2', '\x2', '\xCF', '\xD0', '\a', 'P', '\x2', '\x2', '\xD0', 
		'\xD2', '\a', 'I', '\x2', '\x2', '\xD1', '\xB9', '\x3', '\x2', '\x2', 
		'\x2', '\xD1', '\xBE', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xC2', '\x3', 
		'\x2', '\x2', '\x2', '\xD1', '\xCA', '\x3', '\x2', '\x2', '\x2', '\xD2', 
		'&', '\x3', '\x2', '\x2', '\x2', '\xD3', '\xD4', '\a', '\x45', '\x2', 
		'\x2', '\xD4', '\xD5', '\a', 'Q', '\x2', '\x2', '\xD5', '\xD6', '\a', 
		'O', '\x2', '\x2', '\xD6', '\xD7', '\a', 'O', '\x2', '\x2', '\xD7', '\xD8', 
		'\a', 'Q', '\x2', '\x2', '\xD8', '\xEE', '\a', 'P', '\x2', '\x2', '\xD9', 
		'\xDA', '\a', 'N', '\x2', '\x2', '\xDA', '\xDB', '\a', '\x43', '\x2', 
		'\x2', '\xDB', '\xDC', '\a', 'T', '\x2', '\x2', '\xDC', '\xDD', '\a', 
		'I', '\x2', '\x2', '\xDD', '\xEE', '\a', 'G', '\x2', '\x2', '\xDE', '\xDF', 
		'\a', 'G', '\x2', '\x2', '\xDF', '\xE0', '\a', 'P', '\x2', '\x2', '\xE0', 
		'\xE1', '\a', '\x46', '\x2', '\x2', '\xE1', '\xE2', '\a', 'W', '\x2', 
		'\x2', '\xE2', '\xE3', '\a', 'T', '\x2', '\x2', '\xE3', '\xE4', '\a', 
		'K', '\x2', '\x2', '\xE4', '\xE5', '\a', 'P', '\x2', '\x2', '\xE5', '\xEE', 
		'\a', 'I', '\x2', '\x2', '\xE6', '\xE7', '\a', 'T', '\x2', '\x2', '\xE7', 
		'\xE8', '\a', 'W', '\x2', '\x2', '\xE8', '\xE9', '\a', 'P', '\x2', '\x2', 
		'\xE9', '\xEA', '\a', 'P', '\x2', '\x2', '\xEA', '\xEB', '\a', 'K', '\x2', 
		'\x2', '\xEB', '\xEC', '\a', 'P', '\x2', '\x2', '\xEC', '\xEE', '\a', 
		'I', '\x2', '\x2', '\xED', '\xD3', '\x3', '\x2', '\x2', '\x2', '\xED', 
		'\xD9', '\x3', '\x2', '\x2', '\x2', '\xED', '\xDE', '\x3', '\x2', '\x2', 
		'\x2', '\xED', '\xE6', '\x3', '\x2', '\x2', '\x2', '\xEE', '(', '\x3', 
		'\x2', '\x2', '\x2', '\xEF', '\xF0', '\a', 'I', '\x2', '\x2', '\xF0', 
		'\xF1', '\a', 'T', '\x2', '\x2', '\xF1', '\xF2', '\a', 'G', '\x2', '\x2', 
		'\xF2', '\xF3', '\a', '\x43', '\x2', '\x2', '\xF3', '\x10E', '\a', 'V', 
		'\x2', '\x2', '\xF4', '\xF5', '\a', 'O', '\x2', '\x2', '\xF5', '\xF6', 
		'\a', '\x43', '\x2', '\x2', '\xF6', '\xF7', '\a', 'L', '\x2', '\x2', '\xF7', 
		'\xF8', '\a', 'G', '\x2', '\x2', '\xF8', '\xF9', '\a', 'U', '\x2', '\x2', 
		'\xF9', '\xFA', '\a', 'V', '\x2', '\x2', '\xFA', '\xFB', '\a', 'K', '\x2', 
		'\x2', '\xFB', '\x10E', '\a', '\x45', '\x2', '\x2', '\xFC', '\xFD', '\a', 
		'G', '\x2', '\x2', '\xFD', '\xFE', '\a', 'X', '\x2', '\x2', '\xFE', '\xFF', 
		'\a', 'G', '\x2', '\x2', '\xFF', '\x100', '\a', 'T', '\x2', '\x2', '\x100', 
		'\x101', '\a', 'N', '\x2', '\x2', '\x101', '\x102', '\a', '\x43', '\x2', 
		'\x2', '\x102', '\x103', '\a', 'U', '\x2', '\x2', '\x103', '\x104', '\a', 
		'V', '\x2', '\x2', '\x104', '\x105', '\a', 'K', '\x2', '\x2', '\x105', 
		'\x106', '\a', 'P', '\x2', '\x2', '\x106', '\x10E', '\a', 'I', '\x2', 
		'\x2', '\x107', '\x108', '\a', 'H', '\x2', '\x2', '\x108', '\x109', '\a', 
		'N', '\x2', '\x2', '\x109', '\x10A', '\a', '[', '\x2', '\x2', '\x10A', 
		'\x10B', '\a', 'K', '\x2', '\x2', '\x10B', '\x10C', '\a', 'P', '\x2', 
		'\x2', '\x10C', '\x10E', '\a', 'I', '\x2', '\x2', '\x10D', '\xEF', '\x3', 
		'\x2', '\x2', '\x2', '\x10D', '\xF4', '\x3', '\x2', '\x2', '\x2', '\x10D', 
		'\xFC', '\x3', '\x2', '\x2', '\x2', '\x10D', '\x107', '\x3', '\x2', '\x2', 
		'\x2', '\x10E', '*', '\x3', '\x2', '\x2', '\x2', '\x10F', '\x113', '\x5', 
		'%', '\x13', '\x2', '\x110', '\x113', '\x5', '\'', '\x14', '\x2', '\x111', 
		'\x113', '\x5', ')', '\x15', '\x2', '\x112', '\x10F', '\x3', '\x2', '\x2', 
		'\x2', '\x112', '\x110', '\x3', '\x2', '\x2', '\x2', '\x112', '\x111', 
		'\x3', '\x2', '\x2', '\x2', '\x113', ',', '\x3', '\x2', '\x2', '\x2', 
		'\x114', '\x115', '\a', '\x44', '\x2', '\x2', '\x115', '\x116', '\a', 
		'W', '\x2', '\x2', '\x116', '\x117', '\a', 'H', '\x2', '\x2', '\x117', 
		'\x118', '\a', 'H', '\x2', '\x2', '\x118', '.', '\x3', '\x2', '\x2', '\x2', 
		'\x119', '\x11A', '\a', '\x46', '\x2', '\x2', '\x11A', '\x11B', '\a', 
		'G', '\x2', '\x2', '\x11B', '\x11C', '\a', '\x44', '\x2', '\x2', '\x11C', 
		'\x11D', '\a', 'W', '\x2', '\x2', '\x11D', '\x11E', '\a', 'H', '\x2', 
		'\x2', '\x11E', '\x11F', '\a', 'H', '\x2', '\x2', '\x11F', '\x30', '\x3', 
		'\x2', '\x2', '\x2', '\x120', '\x123', '\x5', '-', '\x17', '\x2', '\x121', 
		'\x123', '\x5', '/', '\x18', '\x2', '\x122', '\x120', '\x3', '\x2', '\x2', 
		'\x2', '\x122', '\x121', '\x3', '\x2', '\x2', '\x2', '\x123', '\x32', 
		'\x3', '\x2', '\x2', '\x2', '\x124', '\x125', '\a', 'Y', '\x2', '\x2', 
		'\x125', '\x126', '\a', 'K', '\x2', '\x2', '\x126', '\x127', '\a', 'U', 
		'\x2', '\x2', '\x127', '\x128', '\a', 'G', '\x2', '\x2', '\x128', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\x129', '\x12A', '\t', '\x2', '\x2', '\x2', 
		'\x12A', '\x12B', '\x3', '\x2', '\x2', '\x2', '\x12B', '\x12C', '\b', 
		'\x1B', '\x2', '\x2', '\x12C', '\x36', '\x3', '\x2', '\x2', '\x2', '\x12D', 
		'\x12E', '\a', 'K', '\x2', '\x2', '\x12E', '\x135', '\a', 'P', '\x2', 
		'\x2', '\x12F', '\x130', '\a', '\x43', '\x2', '\x2', '\x130', '\x135', 
		'\a', 'U', '\x2', '\x2', '\x131', '\x132', '\a', '\x43', '\x2', '\x2', 
		'\x132', '\x133', '\a', 'P', '\x2', '\x2', '\x133', '\x135', '\a', '\x46', 
		'\x2', '\x2', '\x134', '\x12D', '\x3', '\x2', '\x2', '\x2', '\x134', '\x12F', 
		'\x3', '\x2', '\x2', '\x2', '\x134', '\x131', '\x3', '\x2', '\x2', '\x2', 
		'\x135', '\x38', '\x3', '\x2', '\x2', '\x2', '\t', '\x2', '\xD1', '\xED', 
		'\x10D', '\x112', '\x122', '\x134', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
