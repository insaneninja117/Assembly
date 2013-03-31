// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.0
// Machine:  LEXY-PC
// DateTime: 29/03/2013 14:25:35
// UserName: Alex Reed
// Input file <Blam\Scripting\Analysis\LispScriptParser.y - 29/03/2013 11:41:30>

// options: lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using System.Diagnostics;

namespace Blamite.Blam.Scripting.Analysis
{
public enum LispScriptTokens {error=45,EOF=46,GLOBAL=47,SCRIPT=48,
    NAME=49,FLOAT=50,STRING=51,BOOLEAN=52,NONE=53};

public struct ValueType
#line 7 "Blam\Scripting\Analysis\LispScriptParser.y"
{
#line 8 "Blam\Scripting\Analysis\LispScriptParser.y"
    public float FloatValue;
#line 9 "Blam\Scripting\Analysis\LispScriptParser.y"
    public string StringValue;
#line 10 "Blam\Scripting\Analysis\LispScriptParser.y"
    public bool BooleanValue;
#line 11 "Blam\Scripting\Analysis\LispScriptParser.y"
    public IScriptNode Node;
#line 12 "Blam\Scripting\Analysis\LispScriptParser.y"
    public List<IScriptNode> NodeList;
#line 13 "Blam\Scripting\Analysis\LispScriptParser.y"
    public ScriptDefinitionParam Parameter;
#line 14 "Blam\Scripting\Analysis\LispScriptParser.y"
    public List<ScriptDefinitionParam> ParamList;
#line 15 "Blam\Scripting\Analysis\LispScriptParser.y"
}
// Abstract base class for GPLEX scanners
public abstract class LispScriptScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
public class ScanObj {
  public int token;
  public ValueType yylval;
  public LexLocation yylloc;
  public ScanObj( int t, ValueType val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

public class LispScriptParser: ShiftReduceParser<ValueType, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[26];
  private static State[] states = new State[48];
  private static string[] nonTerms = new string[] {
      "declarations", "scriptname", "declaration", "globaldecl", "scriptdecl", 
      "expression", "constant", "functioncall", "variable", "expressions", "parameter", 
      "parameters", "$accept", };

  static LispScriptParser() {
    states[0] = new State(-2,new int[]{-1,1});
    states[1] = new State(new int[]{46,2,40,5},new int[]{-3,3,-4,4,-5,47});
    states[2] = new State(-1);
    states[3] = new State(-3);
    states[4] = new State(-4);
    states[5] = new State(new int[]{47,6,48,28});
    states[6] = new State(new int[]{49,7});
    states[7] = new State(new int[]{49,8});
    states[8] = new State(new int[]{50,12,51,13,52,14,53,15,40,17,49,24},new int[]{-6,9,-7,11,-8,16,-9,23});
    states[9] = new State(new int[]{41,10});
    states[10] = new State(-6);
    states[11] = new State(-16);
    states[12] = new State(-19);
    states[13] = new State(-20);
    states[14] = new State(-21);
    states[15] = new State(-22);
    states[16] = new State(-17);
    states[17] = new State(new int[]{49,26,50,27},new int[]{-2,18});
    states[18] = new State(new int[]{41,19,50,12,51,13,52,14,53,15,40,17,49,24},new int[]{-10,20,-6,25,-7,11,-8,16,-9,23});
    states[19] = new State(-23);
    states[20] = new State(new int[]{41,21,50,12,51,13,52,14,53,15,40,17,49,24},new int[]{-6,22,-7,11,-8,16,-9,23});
    states[21] = new State(-24);
    states[22] = new State(-15);
    states[23] = new State(-18);
    states[24] = new State(-25);
    states[25] = new State(-14);
    states[26] = new State(-7);
    states[27] = new State(-8);
    states[28] = new State(new int[]{49,29});
    states[29] = new State(new int[]{49,30});
    states[30] = new State(new int[]{40,34,49,26,50,27},new int[]{-2,31});
    states[31] = new State(new int[]{50,12,51,13,52,14,53,15,40,17,49,24},new int[]{-10,32,-6,25,-7,11,-8,16,-9,23});
    states[32] = new State(new int[]{41,33,50,12,51,13,52,14,53,15,40,17,49,24},new int[]{-6,22,-7,11,-8,16,-9,23});
    states[33] = new State(-9);
    states[34] = new State(new int[]{49,26,50,27},new int[]{-2,35});
    states[35] = new State(new int[]{40,36});
    states[36] = new State(new int[]{49,44},new int[]{-12,37,-11,46});
    states[37] = new State(new int[]{41,38,44,42});
    states[38] = new State(new int[]{41,39});
    states[39] = new State(new int[]{50,12,51,13,52,14,53,15,40,17,49,24},new int[]{-10,40,-6,25,-7,11,-8,16,-9,23});
    states[40] = new State(new int[]{41,41,50,12,51,13,52,14,53,15,40,17,49,24},new int[]{-6,22,-7,11,-8,16,-9,23});
    states[41] = new State(-10);
    states[42] = new State(new int[]{49,44},new int[]{-11,43});
    states[43] = new State(-12);
    states[44] = new State(new int[]{49,45});
    states[45] = new State(-13);
    states[46] = new State(-11);
    states[47] = new State(-5);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-13, new int[]{-1,46});
    rules[2] = new Rule(-1, new int[]{});
    rules[3] = new Rule(-1, new int[]{-1,-3});
    rules[4] = new Rule(-3, new int[]{-4});
    rules[5] = new Rule(-3, new int[]{-5});
    rules[6] = new Rule(-4, new int[]{40,47,49,49,-6,41});
    rules[7] = new Rule(-2, new int[]{49});
    rules[8] = new Rule(-2, new int[]{50});
    rules[9] = new Rule(-5, new int[]{40,48,49,49,-2,-10,41});
    rules[10] = new Rule(-5, new int[]{40,48,49,49,40,-2,40,-12,41,41,-10,41});
    rules[11] = new Rule(-12, new int[]{-11});
    rules[12] = new Rule(-12, new int[]{-12,44,-11});
    rules[13] = new Rule(-11, new int[]{49,49});
    rules[14] = new Rule(-10, new int[]{-6});
    rules[15] = new Rule(-10, new int[]{-10,-6});
    rules[16] = new Rule(-6, new int[]{-7});
    rules[17] = new Rule(-6, new int[]{-8});
    rules[18] = new Rule(-6, new int[]{-9});
    rules[19] = new Rule(-7, new int[]{50});
    rules[20] = new Rule(-7, new int[]{51});
    rules[21] = new Rule(-7, new int[]{52});
    rules[22] = new Rule(-7, new int[]{53});
    rules[23] = new Rule(-8, new int[]{40,-2,41});
    rules[24] = new Rule(-8, new int[]{40,-2,-10,41});
    rules[25] = new Rule(-9, new int[]{49});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)LispScriptTokens.error, (int)LispScriptTokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 3: // declarations -> declarations, declaration
#line 37 "Blam\Scripting\Analysis\LispScriptParser.y"
{ Nodes.Add(ValueStack[ValueStack.Depth-1].Node); }
        break;
      case 6: // globaldecl -> '(', GLOBAL, NAME, NAME, expression, ')'
#line 45 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.Node = new GlobalDefinitionNode(ValueStack[ValueStack.Depth-3].StringValue, ValueStack[ValueStack.Depth-4].StringValue, ValueStack[ValueStack.Depth-2].Node); }
        break;
      case 8: // scriptname -> FLOAT
#line 51 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.StringValue = ValueStack[ValueStack.Depth-1].FloatValue.ToString(); }
        break;
      case 9: // scriptdecl -> '(', SCRIPT, NAME, NAME, scriptname, expressions, ')'
#line 55 "Blam\Scripting\Analysis\LispScriptParser.y"
{
#line 56 "Blam\Scripting\Analysis\LispScriptParser.y"
                   var def = new ScriptDefinitionNode(ValueStack[ValueStack.Depth-3].StringValue, ValueStack[ValueStack.Depth-5].StringValue, ValueStack[ValueStack.Depth-4].StringValue);
#line 57 "Blam\Scripting\Analysis\LispScriptParser.y"
                   def.Nodes.AddRange(ValueStack[ValueStack.Depth-2].NodeList);
#line 58 "Blam\Scripting\Analysis\LispScriptParser.y"
                   CurrentSemanticValue.Node = def;
#line 59 "Blam\Scripting\Analysis\LispScriptParser.y"
               }
        break;
      case 10: // scriptdecl -> '(', SCRIPT, NAME, NAME, '(', scriptname, '(', parameters, ')', 
               //               ')', expressions, ')'
#line 61 "Blam\Scripting\Analysis\LispScriptParser.y"
{
#line 62 "Blam\Scripting\Analysis\LispScriptParser.y"
                   var def = new ScriptDefinitionNode(ValueStack[ValueStack.Depth-7].StringValue, ValueStack[ValueStack.Depth-10].StringValue, ValueStack[ValueStack.Depth-9].StringValue);
#line 63 "Blam\Scripting\Analysis\LispScriptParser.y"
                   def.Parameters.AddRange(ValueStack[ValueStack.Depth-5].ParamList);
#line 64 "Blam\Scripting\Analysis\LispScriptParser.y"
                   def.Nodes.AddRange(ValueStack[ValueStack.Depth-2].NodeList);
#line 65 "Blam\Scripting\Analysis\LispScriptParser.y"
                   CurrentSemanticValue.Node = def;
#line 66 "Blam\Scripting\Analysis\LispScriptParser.y"
               }
        break;
      case 11: // parameters -> parameter
#line 70 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.ParamList = new List<ScriptDefinitionParam>(); CurrentSemanticValue.ParamList.Add(ValueStack[ValueStack.Depth-1].Parameter); }
        break;
      case 12: // parameters -> parameters, ',', parameter
#line 72 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.ParamList = ValueStack[ValueStack.Depth-3].ParamList; CurrentSemanticValue.ParamList.Add(ValueStack[ValueStack.Depth-1].Parameter); }
        break;
      case 13: // parameter -> NAME, NAME
#line 76 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.Parameter = new ScriptDefinitionParam(ValueStack[ValueStack.Depth-1].StringValue, ValueStack[ValueStack.Depth-2].StringValue); }
        break;
      case 14: // expressions -> expression
#line 80 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.NodeList = new List<IScriptNode>(); CurrentSemanticValue.NodeList.Add(ValueStack[ValueStack.Depth-1].Node); }
        break;
      case 15: // expressions -> expressions, expression
#line 82 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.NodeList = ValueStack[ValueStack.Depth-2].NodeList; CurrentSemanticValue.NodeList.Add(ValueStack[ValueStack.Depth-1].Node); }
        break;
      case 19: // constant -> FLOAT
#line 91 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.Node = new ConstantNode(ValueStack[ValueStack.Depth-1].FloatValue); }
        break;
      case 20: // constant -> STRING
#line 93 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.Node = new ConstantNode(ValueStack[ValueStack.Depth-1].StringValue); }
        break;
      case 21: // constant -> BOOLEAN
#line 95 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.Node = new ConstantNode(ValueStack[ValueStack.Depth-1].BooleanValue); }
        break;
      case 22: // constant -> NONE
#line 97 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.Node = new ConstantNode(); }
        break;
      case 23: // functioncall -> '(', scriptname, ')'
#line 101 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.Node = new FunctionCallNode(ValueStack[ValueStack.Depth-2].StringValue); }
        break;
      case 24: // functioncall -> '(', scriptname, expressions, ')'
#line 103 "Blam\Scripting\Analysis\LispScriptParser.y"
{
#line 104 "Blam\Scripting\Analysis\LispScriptParser.y"
                     var call = new FunctionCallNode(ValueStack[ValueStack.Depth-3].StringValue);
#line 105 "Blam\Scripting\Analysis\LispScriptParser.y"
                     call.Arguments.AddRange(ValueStack[ValueStack.Depth-2].NodeList);
#line 106 "Blam\Scripting\Analysis\LispScriptParser.y"
                     CurrentSemanticValue.Node = call;
#line 107 "Blam\Scripting\Analysis\LispScriptParser.y"
                 }
        break;
      case 25: // variable -> NAME
#line 111 "Blam\Scripting\Analysis\LispScriptParser.y"
{ CurrentSemanticValue.Node = new VariableReferenceNode(ValueStack[ValueStack.Depth-1].StringValue); }
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((LispScriptTokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((LispScriptTokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

#line 115 "Blam\Scripting\Analysis\LispScriptParser.y"

#line 116 "Blam\Scripting\Analysis\LispScriptParser.y"
public LispScriptParser(LispScriptScanner sc)
#line 117 "Blam\Scripting\Analysis\LispScriptParser.y"
	: base(sc)
#line 118 "Blam\Scripting\Analysis\LispScriptParser.y"
{
#line 119 "Blam\Scripting\Analysis\LispScriptParser.y"
    Nodes = new List<IScriptNode>();
#line 120 "Blam\Scripting\Analysis\LispScriptParser.y"
}
#line 121 "Blam\Scripting\Analysis\LispScriptParser.y"

#line 122 "Blam\Scripting\Analysis\LispScriptParser.y"
public List<IScriptNode> Nodes { get; private set; }
}
}
