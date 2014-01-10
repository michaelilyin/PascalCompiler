// $ANTLR 3.2 Sep 23, 2009 12:02:23 PascalGrammar.g 2014-01-10 21:51:44

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


  using System.Collections.Generic;
  using System.Globalization;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  PascalCompiler 
{
public partial class PascalGrammarParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"PROGRAM", 
		"VAR", 
		"BLOCK", 
		"PARAMS", 
		"METHODS", 
		"STRING_CONST", 
		"SEMICOLON", 
		"BLOCKOPEN", 
		"BLOCKEND", 
		"FUNCTION", 
		"PROCEDURE", 
		"FUNC_CALL", 
		"CONVERT", 
		"IF", 
		"THEN", 
		"ELSE", 
		"FOR", 
		"TO", 
		"DO", 
		"WHILE", 
		"AND", 
		"OR", 
		"XOR", 
		"NOT", 
		"BOOLEAN", 
		"IDENT", 
		"NUMBER", 
		"COMMENT", 
		"STRING", 
		"WS", 
		"ADD", 
		"SUB", 
		"MUL", 
		"DIV", 
		"ASSIGN", 
		"COMPARE", 
		"'('", 
		"')'", 
		"','", 
		"':'", 
		"'.'"
    };

    public const int T__42 = 42;
    public const int FUNCTION = 13;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int XOR = 26;
    public const int T__44 = 44;
    public const int WHILE = 23;
    public const int CONVERT = 16;
    public const int TO = 21;
    public const int ELSE = 19;
    public const int NUMBER = 30;
    public const int DO = 22;
    public const int FOR = 20;
    public const int SUB = 35;
    public const int SEMICOLON = 10;
    public const int NOT = 27;
    public const int AND = 24;
    public const int EOF = -1;
    public const int MUL = 36;
    public const int PROCEDURE = 14;
    public const int IF = 17;
    public const int FUNC_CALL = 15;
    public const int BLOCKOPEN = 11;
    public const int WS = 33;
    public const int BOOLEAN = 28;
    public const int THEN = 18;
    public const int METHODS = 8;
    public const int STRING_CONST = 9;
    public const int BLOCK = 6;
    public const int BLOCKEND = 12;
    public const int OR = 25;
    public const int ASSIGN = 38;
    public const int COMPARE = 39;
    public const int IDENT = 29;
    public const int PROGRAM = 4;
    public const int VAR = 5;
    public const int DIV = 37;
    public const int COMMENT = 31;
    public const int STRING = 32;
    public const int ADD = 34;
    public const int PARAMS = 7;

    // delegates
    // delegators



        public PascalGrammarParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PascalGrammarParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[66+1];
             
             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return PascalGrammarParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "PascalGrammar.g"; }
    }


      // number format with decimal separator - '.'
      public static readonly NumberFormatInfo NFI = new NumberFormatInfo();
      private Stack<String> stack = new Stack<String>();
      

    public class group_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "group"
    // PascalGrammar.g:85:1: group : ( '(' term ')' | NUMBER -> NUMBER[double.Parse($NUMBER.text, NFI)] | BOOLEAN | func_call | IDENT | STRING -> STRING[$STRING.text] );
    public PascalGrammarParser.group_return group() // throws RecognitionException [1]
    {   
        PascalGrammarParser.group_return retval = new PascalGrammarParser.group_return();
        retval.Start = input.LT(1);
        int group_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal1 = null;
        IToken char_literal3 = null;
        IToken NUMBER4 = null;
        IToken BOOLEAN5 = null;
        IToken IDENT7 = null;
        IToken STRING8 = null;
        PascalGrammarParser.term_return term2 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.func_call_return func_call6 = default(PascalGrammarParser.func_call_return);


        object char_literal1_tree=null;
        object char_literal3_tree=null;
        object NUMBER4_tree=null;
        object BOOLEAN5_tree=null;
        object IDENT7_tree=null;
        object STRING8_tree=null;
        RewriteRuleTokenStream stream_STRING = new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleTokenStream stream_NUMBER = new RewriteRuleTokenStream(adaptor,"token NUMBER");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:86:2: ( '(' term ')' | NUMBER -> NUMBER[double.Parse($NUMBER.text, NFI)] | BOOLEAN | func_call | IDENT | STRING -> STRING[$STRING.text] )
            int alt1 = 6;
            switch ( input.LA(1) ) 
            {
            case 40:
            	{
                alt1 = 1;
                }
                break;
            case NUMBER:
            	{
                alt1 = 2;
                }
                break;
            case BOOLEAN:
            	{
                alt1 = 3;
                }
                break;
            case IDENT:
            	{
                int LA1_4 = input.LA(2);

                if ( (LA1_4 == 40) )
                {
                    alt1 = 4;
                }
                else if ( (LA1_4 == EOF || LA1_4 == SEMICOLON || LA1_4 == BLOCKEND || (LA1_4 >= THEN && LA1_4 <= ELSE) || (LA1_4 >= TO && LA1_4 <= XOR) || (LA1_4 >= ADD && LA1_4 <= DIV) || LA1_4 == COMPARE || (LA1_4 >= 41 && LA1_4 <= 42)) )
                {
                    alt1 = 5;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d1s4 =
                        new NoViableAltException("", 1, 4, input);

                    throw nvae_d1s4;
                }
                }
                break;
            case STRING:
            	{
                alt1 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // PascalGrammar.g:87:2: '(' term ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal1=(IToken)Match(input,40,FOLLOW_40_in_group591); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_group594);
                    	term2 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
                    	char_literal3=(IToken)Match(input,41,FOLLOW_41_in_group596); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:88:4: NUMBER
                    {
                    	NUMBER4=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_group602); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_NUMBER.Add(NUMBER4);



                    	// AST REWRITE
                    	// elements:          NUMBER
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 88:11: -> NUMBER[double.Parse($NUMBER.text, NFI)]
                    	{
                    	    adaptor.AddChild(root_0, new NumAstNode(NUMBER, double.Parse(((NUMBER4 != null) ? NUMBER4.Text : null), NFI)));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // PascalGrammar.g:89:4: BOOLEAN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BOOLEAN5=(IToken)Match(input,BOOLEAN,FOLLOW_BOOLEAN_in_group615); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BOOLEAN5_tree = (object)adaptor.Create(BOOLEAN5);
                    		adaptor.AddChild(root_0, BOOLEAN5_tree);
                    	}

                    }
                    break;
                case 4 :
                    // PascalGrammar.g:90:4: func_call
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_group620);
                    	func_call6 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call6.Tree);

                    }
                    break;
                case 5 :
                    // PascalGrammar.g:91:4: IDENT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT7=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_group625); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT7_tree = (object)adaptor.Create(IDENT7);
                    		adaptor.AddChild(root_0, IDENT7_tree);
                    	}

                    }
                    break;
                case 6 :
                    // PascalGrammar.g:92:4: STRING
                    {
                    	STRING8=(IToken)Match(input,STRING,FOLLOW_STRING_in_group630); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_STRING.Add(STRING8);



                    	// AST REWRITE
                    	// elements:          STRING
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 92:11: -> STRING[$STRING.text]
                    	{
                    	    adaptor.AddChild(root_0, new StringAstNode(STRING, ((STRING8 != null) ? STRING8.Text : null)));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, group_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "group"

    public class denial_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "denial"
    // PascalGrammar.g:95:1: denial : ( NOT )? group ;
    public PascalGrammarParser.denial_return denial() // throws RecognitionException [1]
    {   
        PascalGrammarParser.denial_return retval = new PascalGrammarParser.denial_return();
        retval.Start = input.LT(1);
        int denial_StartIndex = input.Index();
        object root_0 = null;

        IToken NOT9 = null;
        PascalGrammarParser.group_return group10 = default(PascalGrammarParser.group_return);


        object NOT9_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:95:8: ( ( NOT )? group )
            // PascalGrammar.g:95:10: ( NOT )? group
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// PascalGrammar.g:95:13: ( NOT )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == NOT) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:0:0: NOT
            	        {
            	        	NOT9=(IToken)Match(input,NOT,FOLLOW_NOT_in_denial651); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{NOT9_tree = (object)adaptor.Create(NOT9);
            	        		root_0 = (object)adaptor.BecomeRoot(NOT9_tree, root_0);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_group_in_denial655);
            	group10 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group10.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, denial_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "denial"

    public class mult_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mult"
    // PascalGrammar.g:96:1: mult : denial ( ( MUL | DIV | AND ) denial )* ;
    public PascalGrammarParser.mult_return mult() // throws RecognitionException [1]
    {   
        PascalGrammarParser.mult_return retval = new PascalGrammarParser.mult_return();
        retval.Start = input.LT(1);
        int mult_StartIndex = input.Index();
        object root_0 = null;

        IToken set12 = null;
        PascalGrammarParser.denial_return denial11 = default(PascalGrammarParser.denial_return);

        PascalGrammarParser.denial_return denial13 = default(PascalGrammarParser.denial_return);


        object set12_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:96:5: ( denial ( ( MUL | DIV | AND ) denial )* )
            // PascalGrammar.g:96:7: denial ( ( MUL | DIV | AND ) denial )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_denial_in_mult667);
            	denial11 = denial();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, denial11.Tree);
            	// PascalGrammar.g:96:14: ( ( MUL | DIV | AND ) denial )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == AND || (LA3_0 >= MUL && LA3_0 <= DIV)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // PascalGrammar.g:96:16: ( MUL | DIV | AND ) denial
            			    {
            			    	set12=(IToken)input.LT(1);
            			    	set12 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == AND || (input.LA(1) >= MUL && input.LA(1) <= DIV) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set12), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_denial_in_mult686);
            			    	denial13 = denial();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, denial13.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, mult_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "mult"

    public class add_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "add"
    // PascalGrammar.g:97:1: add : mult ( ( ADD | SUB | OR | XOR ) mult )* ;
    public PascalGrammarParser.add_return add() // throws RecognitionException [1]
    {   
        PascalGrammarParser.add_return retval = new PascalGrammarParser.add_return();
        retval.Start = input.LT(1);
        int add_StartIndex = input.Index();
        object root_0 = null;

        IToken set15 = null;
        PascalGrammarParser.mult_return mult14 = default(PascalGrammarParser.mult_return);

        PascalGrammarParser.mult_return mult16 = default(PascalGrammarParser.mult_return);


        object set15_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:97:4: ( mult ( ( ADD | SUB | OR | XOR ) mult )* )
            // PascalGrammar.g:97:7: mult ( ( ADD | SUB | OR | XOR ) mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add698);
            	mult14 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult14.Tree);
            	// PascalGrammar.g:97:13: ( ( ADD | SUB | OR | XOR ) mult )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= OR && LA4_0 <= XOR) || (LA4_0 >= ADD && LA4_0 <= SUB)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // PascalGrammar.g:97:15: ( ADD | SUB | OR | XOR ) mult
            			    {
            			    	set15=(IToken)input.LT(1);
            			    	set15 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= OR && input.LA(1) <= XOR) || (input.LA(1) >= ADD && input.LA(1) <= SUB) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set15), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_mult_in_add722);
            			    	mult16 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult16.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, add_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "add"

    public class compare_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "compare"
    // PascalGrammar.g:98:1: compare : add ( COMPARE add )* ;
    public PascalGrammarParser.compare_return compare() // throws RecognitionException [1]
    {   
        PascalGrammarParser.compare_return retval = new PascalGrammarParser.compare_return();
        retval.Start = input.LT(1);
        int compare_StartIndex = input.Index();
        object root_0 = null;

        IToken COMPARE18 = null;
        PascalGrammarParser.add_return add17 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.add_return add19 = default(PascalGrammarParser.add_return);


        object COMPARE18_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:98:9: ( add ( COMPARE add )* )
            // PascalGrammar.g:98:11: add ( COMPARE add )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_compare735);
            	add17 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add17.Tree);
            	// PascalGrammar.g:98:15: ( COMPARE add )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == COMPARE) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // PascalGrammar.g:98:17: COMPARE add
            			    {
            			    	COMPARE18=(IToken)Match(input,COMPARE,FOLLOW_COMPARE_in_compare739); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMPARE18_tree = (object)adaptor.Create(COMPARE18);
            			    		root_0 = (object)adaptor.BecomeRoot(COMPARE18_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_add_in_compare742);
            			    	add19 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add19.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, compare_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "compare"

    public class term_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "term"
    // PascalGrammar.g:99:1: term : compare ;
    public PascalGrammarParser.term_return term() // throws RecognitionException [1]
    {   
        PascalGrammarParser.term_return retval = new PascalGrammarParser.term_return();
        retval.Start = input.LT(1);
        int term_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.compare_return compare20 = default(PascalGrammarParser.compare_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:99:6: ( compare )
            // PascalGrammar.g:99:8: compare
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_compare_in_term751);
            	compare20 = compare();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare20.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, term_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "term"

    public class arg_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arg_list"
    // PascalGrammar.g:101:1: arg_list : ( term ( ',' term )* )? ;
    public PascalGrammarParser.arg_list_return arg_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.arg_list_return retval = new PascalGrammarParser.arg_list_return();
        retval.Start = input.LT(1);
        int arg_list_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal22 = null;
        PascalGrammarParser.term_return term21 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.term_return term23 = default(PascalGrammarParser.term_return);


        object char_literal22_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:101:9: ( ( term ( ',' term )* )? )
            // PascalGrammar.g:101:11: ( term ( ',' term )* )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// PascalGrammar.g:101:11: ( term ( ',' term )* )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( ((LA7_0 >= NOT && LA7_0 <= NUMBER) || LA7_0 == STRING || LA7_0 == 40) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:101:13: term ( ',' term )*
            	        {
            	        	PushFollow(FOLLOW_term_in_arg_list760);
            	        	term21 = term();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term21.Tree);
            	        	// PascalGrammar.g:101:18: ( ',' term )*
            	        	do 
            	        	{
            	        	    int alt6 = 2;
            	        	    int LA6_0 = input.LA(1);

            	        	    if ( (LA6_0 == 42) )
            	        	    {
            	        	        alt6 = 1;
            	        	    }


            	        	    switch (alt6) 
            	        		{
            	        			case 1 :
            	        			    // PascalGrammar.g:101:19: ',' term
            	        			    {
            	        			    	char_literal22=(IToken)Match(input,42,FOLLOW_42_in_arg_list763); if (state.failed) return retval;
            	        			    	PushFollow(FOLLOW_term_in_arg_list766);
            	        			    	term23 = term();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term23.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop6;
            	        	    }
            	        	} while (true);

            	        	loop6:
            	        		;	// Stops C# compiler whining that label 'loop6' has no statements


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, arg_list_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "arg_list"

    public class func_call_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "func_call"
    // PascalGrammar.g:103:1: func_call : IDENT ( '(' arg_list ')' ) -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? ) ;
    public PascalGrammarParser.func_call_return func_call() // throws RecognitionException [1]
    {   
        PascalGrammarParser.func_call_return retval = new PascalGrammarParser.func_call_return();
        retval.Start = input.LT(1);
        int func_call_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT24 = null;
        IToken char_literal25 = null;
        IToken char_literal27 = null;
        PascalGrammarParser.arg_list_return arg_list26 = default(PascalGrammarParser.arg_list_return);


        object IDENT24_tree=null;
        object char_literal25_tree=null;
        object char_literal27_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_arg_list = new RewriteRuleSubtreeStream(adaptor,"rule arg_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:104:2: ( IDENT ( '(' arg_list ')' ) -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? ) )
            // PascalGrammar.g:105:2: IDENT ( '(' arg_list ')' )
            {
            	IDENT24=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_func_call782); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT24);

            	// PascalGrammar.g:105:8: ( '(' arg_list ')' )
            	// PascalGrammar.g:105:9: '(' arg_list ')'
            	{
            		char_literal25=(IToken)Match(input,40,FOLLOW_40_in_func_call785); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_40.Add(char_literal25);

            		PushFollow(FOLLOW_arg_list_in_func_call787);
            		arg_list26 = arg_list();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_arg_list.Add(arg_list26.Tree);
            		char_literal27=(IToken)Match(input,41,FOLLOW_41_in_func_call789); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_41.Add(char_literal27);


            	}



            	// AST REWRITE
            	// elements:          arg_list, IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 105:28: -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? )
            	{
            	    // PascalGrammar.g:105:31: ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // PascalGrammar.g:105:49: ( ^( PARAMS arg_list ) )?
            	    if ( stream_arg_list.HasNext() )
            	    {
            	        // PascalGrammar.g:105:49: ^( PARAMS arg_list )
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

            	        adaptor.AddChild(root_2, stream_arg_list.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_arg_list.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, func_call_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "func_call"

    public class expr_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr"
    // PascalGrammar.g:108:1: expr : ( IDENT | IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare );
    public PascalGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        PascalGrammarParser.expr_return retval = new PascalGrammarParser.expr_return();
        retval.Start = input.LT(1);
        int expr_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT28 = null;
        IToken IDENT29 = null;
        IToken ASSIGN30 = null;
        IToken BLOCKOPEN33 = null;
        IToken BLOCKEND35 = null;
        IToken IF36 = null;
        IToken THEN38 = null;
        IToken ELSE40 = null;
        IToken FOR42 = null;
        IToken IDENT43 = null;
        IToken ASSIGN44 = null;
        IToken TO46 = null;
        IToken DO48 = null;
        IToken WHILE50 = null;
        IToken DO52 = null;
        IToken DO54 = null;
        IToken WHILE56 = null;
        PascalGrammarParser.term_return term31 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.func_call_return func_call32 = default(PascalGrammarParser.func_call_return);

        PascalGrammarParser.expr_list_return expr_list34 = default(PascalGrammarParser.expr_list_return);

        PascalGrammarParser.compare_return compare37 = default(PascalGrammarParser.compare_return);

        PascalGrammarParser.expr_return expr39 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr41 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.add_return add45 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.add_return add47 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.expr_return expr49 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.compare_return compare51 = default(PascalGrammarParser.compare_return);

        PascalGrammarParser.expr_return expr53 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr55 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.compare_return compare57 = default(PascalGrammarParser.compare_return);


        object IDENT28_tree=null;
        object IDENT29_tree=null;
        object ASSIGN30_tree=null;
        object BLOCKOPEN33_tree=null;
        object BLOCKEND35_tree=null;
        object IF36_tree=null;
        object THEN38_tree=null;
        object ELSE40_tree=null;
        object FOR42_tree=null;
        object IDENT43_tree=null;
        object ASSIGN44_tree=null;
        object TO46_tree=null;
        object DO48_tree=null;
        object WHILE50_tree=null;
        object DO52_tree=null;
        object DO54_tree=null;
        object WHILE56_tree=null;
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:108:6: ( IDENT | IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare )
            int alt9 = 8;
            alt9 = dfa9.Predict(input);
            switch (alt9) 
            {
                case 1 :
                    // PascalGrammar.g:109:2: IDENT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT28=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr817); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT28_tree = (object)adaptor.Create(IDENT28);
                    		adaptor.AddChild(root_0, IDENT28_tree);
                    	}

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:110:3: IDENT ASSIGN term
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT29=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr821); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT29_tree = (object)adaptor.Create(IDENT29);
                    		adaptor.AddChild(root_0, IDENT29_tree);
                    	}
                    	ASSIGN30=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr823); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN30_tree = (object)adaptor.Create(ASSIGN30);
                    		root_0 = (object)adaptor.BecomeRoot(ASSIGN30_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr826);
                    	term31 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term31.Tree);

                    }
                    break;
                case 3 :
                    // PascalGrammar.g:111:4: func_call
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_expr831);
                    	func_call32 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call32.Tree);

                    }
                    break;
                case 4 :
                    // PascalGrammar.g:112:4: BLOCKOPEN expr_list BLOCKEND
                    {
                    	BLOCKOPEN33=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_expr836); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN33);

                    	PushFollow(FOLLOW_expr_list_in_expr838);
                    	expr_list34 = expr_list();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list34.Tree);
                    	BLOCKEND35=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_expr840); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND35);



                    	// AST REWRITE
                    	// elements:          expr_list
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 112:33: -> ^( BLOCK expr_list )
                    	{
                    	    // PascalGrammar.g:112:36: ^( BLOCK expr_list )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

                    	    adaptor.AddChild(root_1, stream_expr_list.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 5 :
                    // PascalGrammar.g:113:4: IF compare THEN expr ( ELSE expr )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IF36=(IToken)Match(input,IF,FOLLOW_IF_in_expr853); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IF36_tree = (object)adaptor.Create(IF36);
                    		root_0 = (object)adaptor.BecomeRoot(IF36_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_compare_in_expr856);
                    	compare37 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare37.Tree);
                    	THEN38=(IToken)Match(input,THEN,FOLLOW_THEN_in_expr858); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr861);
                    	expr39 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr39.Tree);
                    	// PascalGrammar.g:113:27: ( ELSE expr )?
                    	int alt8 = 2;
                    	int LA8_0 = input.LA(1);

                    	if ( (LA8_0 == ELSE) )
                    	{
                    	    int LA8_1 = input.LA(2);

                    	    if ( (synpred21_PascalGrammar()) )
                    	    {
                    	        alt8 = 1;
                    	    }
                    	}
                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // PascalGrammar.g:113:28: ELSE expr
                    	        {
                    	        	ELSE40=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_expr864); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_expr_in_expr867);
                    	        	expr41 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr41.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 6 :
                    // PascalGrammar.g:114:4: FOR IDENT ASSIGN add TO add DO expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FOR42=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr874); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FOR42_tree = (object)adaptor.Create(FOR42);
                    		root_0 = (object)adaptor.BecomeRoot(FOR42_tree, root_0);
                    	}
                    	IDENT43=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr877); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT43_tree = (object)adaptor.Create(IDENT43);
                    		adaptor.AddChild(root_0, IDENT43_tree);
                    	}
                    	ASSIGN44=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr879); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_expr882);
                    	add45 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add45.Tree);
                    	TO46=(IToken)Match(input,TO,FOLLOW_TO_in_expr884); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_expr887);
                    	add47 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add47.Tree);
                    	DO48=(IToken)Match(input,DO,FOLLOW_DO_in_expr889); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr892);
                    	expr49 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr49.Tree);

                    }
                    break;
                case 7 :
                    // PascalGrammar.g:115:4: WHILE compare DO expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	WHILE50=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr897); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WHILE50_tree = (object)adaptor.Create(WHILE50);
                    		root_0 = (object)adaptor.BecomeRoot(WHILE50_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_compare_in_expr900);
                    	compare51 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare51.Tree);
                    	DO52=(IToken)Match(input,DO,FOLLOW_DO_in_expr902); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr905);
                    	expr53 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr53.Tree);

                    }
                    break;
                case 8 :
                    // PascalGrammar.g:116:4: DO expr WHILE compare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	DO54=(IToken)Match(input,DO,FOLLOW_DO_in_expr910); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DO54_tree = (object)adaptor.Create(DO54);
                    		root_0 = (object)adaptor.BecomeRoot(DO54_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_expr_in_expr913);
                    	expr55 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr55.Tree);
                    	WHILE56=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr915); if (state.failed) return retval;
                    	PushFollow(FOLLOW_compare_in_expr918);
                    	compare57 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare57.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, expr_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class expr_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr_list"
    // PascalGrammar.g:119:1: expr_list : ( ';' )* expr ( ( ';' )+ expr )* ( ';' )* ;
    public PascalGrammarParser.expr_list_return expr_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.expr_list_return retval = new PascalGrammarParser.expr_list_return();
        retval.Start = input.LT(1);
        int expr_list_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal58 = null;
        IToken char_literal60 = null;
        IToken char_literal62 = null;
        PascalGrammarParser.expr_return expr59 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr61 = default(PascalGrammarParser.expr_return);


        object char_literal58_tree=null;
        object char_literal60_tree=null;
        object char_literal62_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:120:2: ( ( ';' )* expr ( ( ';' )+ expr )* ( ';' )* )
            // PascalGrammar.g:121:2: ( ';' )* expr ( ( ';' )+ expr )* ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// PascalGrammar.g:121:2: ( ';' )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == SEMICOLON) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // PascalGrammar.g:121:3: ';'
            			    {
            			    	char_literal58=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list936); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	PushFollow(FOLLOW_expr_in_expr_list941);
            	expr59 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr59.Tree);
            	// PascalGrammar.g:121:15: ( ( ';' )+ expr )*
            	do 
            	{
            	    int alt12 = 2;
            	    alt12 = dfa12.Predict(input);
            	    switch (alt12) 
            		{
            			case 1 :
            			    // PascalGrammar.g:121:17: ( ';' )+ expr
            			    {
            			    	// PascalGrammar.g:121:17: ( ';' )+
            			    	int cnt11 = 0;
            			    	do 
            			    	{
            			    	    int alt11 = 2;
            			    	    int LA11_0 = input.LA(1);

            			    	    if ( (LA11_0 == SEMICOLON) )
            			    	    {
            			    	        alt11 = 1;
            			    	    }


            			    	    switch (alt11) 
            			    		{
            			    			case 1 :
            			    			    // PascalGrammar.g:121:18: ';'
            			    			    {
            			    			    	char_literal60=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list946); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    if ( cnt11 >= 1 ) goto loop11;
            			    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		            EarlyExitException eee11 =
            			    		                new EarlyExitException(11, input);
            			    		            throw eee11;
            			    	    }
            			    	    cnt11++;
            			    	} while (true);

            			    	loop11:
            			    		;	// Stops C# compiler whining that label 'loop11' has no statements

            			    	PushFollow(FOLLOW_expr_in_expr_list951);
            			    	expr61 = expr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr61.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	// PascalGrammar.g:121:33: ( ';' )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == SEMICOLON) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // PascalGrammar.g:121:34: ';'
            			    {
            			    	char_literal62=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list957); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, expr_list_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expr_list"

    public class program_body_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program_body"
    // PascalGrammar.g:124:1: program_body : expr_list -> ^( BLOCK expr_list ) ;
    public PascalGrammarParser.program_body_return program_body() // throws RecognitionException [1]
    {   
        PascalGrammarParser.program_body_return retval = new PascalGrammarParser.program_body_return();
        retval.Start = input.LT(1);
        int program_body_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.expr_list_return expr_list63 = default(PascalGrammarParser.expr_list_return);


        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:125:2: ( expr_list -> ^( BLOCK expr_list ) )
            // PascalGrammar.g:126:2: expr_list
            {
            	PushFollow(FOLLOW_expr_list_in_program_body974);
            	expr_list63 = expr_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list63.Tree);


            	// AST REWRITE
            	// elements:          expr_list
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 126:12: -> ^( BLOCK expr_list )
            	{
            	    // PascalGrammar.g:126:15: ^( BLOCK expr_list )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    adaptor.AddChild(root_1, stream_expr_list.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, program_body_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "program_body"

    public class ident_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ident_list"
    // PascalGrammar.g:129:1: ident_list : IDENT ( ',' IDENT )* ;
    public PascalGrammarParser.ident_list_return ident_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.ident_list_return retval = new PascalGrammarParser.ident_list_return();
        retval.Start = input.LT(1);
        int ident_list_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT64 = null;
        IToken char_literal65 = null;
        IToken IDENT66 = null;

        object IDENT64_tree=null;
        object char_literal65_tree=null;
        object IDENT66_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:130:2: ( IDENT ( ',' IDENT )* )
            // PascalGrammar.g:131:2: IDENT ( ',' IDENT )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IDENT64=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident_list996); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IDENT64_tree = (object)adaptor.Create(IDENT64);
            		adaptor.AddChild(root_0, IDENT64_tree);
            	}
            	// PascalGrammar.g:131:8: ( ',' IDENT )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 42) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // PascalGrammar.g:131:9: ',' IDENT
            			    {
            			    	char_literal65=(IToken)Match(input,42,FOLLOW_42_in_ident_list999); if (state.failed) return retval;
            			    	IDENT66=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident_list1002); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{IDENT66_tree = (object)adaptor.Create(IDENT66);
            			    		adaptor.AddChild(root_0, IDENT66_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, ident_list_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "ident_list"

    public class type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "type"
    // PascalGrammar.g:134:1: type : ':' IDENT -> ^( IDENT ) ;
    public PascalGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        PascalGrammarParser.type_return retval = new PascalGrammarParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal67 = null;
        IToken IDENT68 = null;

        object char_literal67_tree=null;
        object IDENT68_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:134:6: ( ':' IDENT -> ^( IDENT ) )
            // PascalGrammar.g:135:2: ':' IDENT
            {
            	char_literal67=(IToken)Match(input,43,FOLLOW_43_in_type1017); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_43.Add(char_literal67);

            	IDENT68=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_type1019); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT68);



            	// AST REWRITE
            	// elements:          IDENT
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 135:12: -> ^( IDENT )
            	{
            	    // PascalGrammar.g:135:15: ^( IDENT )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_1);

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, type_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "type"

    public class variables_definition_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variables_definition"
    // PascalGrammar.g:138:1: variables_definition : VAR ( ident_list type ( SEMICOLON )+ )+ -> ^( VAR ( ^( type ident_list ) )+ ) ;
    public PascalGrammarParser.variables_definition_return variables_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.variables_definition_return retval = new PascalGrammarParser.variables_definition_return();
        retval.Start = input.LT(1);
        int variables_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken VAR69 = null;
        IToken SEMICOLON72 = null;
        PascalGrammarParser.ident_list_return ident_list70 = default(PascalGrammarParser.ident_list_return);

        PascalGrammarParser.type_return type71 = default(PascalGrammarParser.type_return);


        object VAR69_tree=null;
        object SEMICOLON72_tree=null;
        RewriteRuleTokenStream stream_VAR = new RewriteRuleTokenStream(adaptor,"token VAR");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleSubtreeStream stream_ident_list = new RewriteRuleSubtreeStream(adaptor,"rule ident_list");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:139:2: ( VAR ( ident_list type ( SEMICOLON )+ )+ -> ^( VAR ( ^( type ident_list ) )+ ) )
            // PascalGrammar.g:140:2: VAR ( ident_list type ( SEMICOLON )+ )+
            {
            	VAR69=(IToken)Match(input,VAR,FOLLOW_VAR_in_variables_definition1038); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_VAR.Add(VAR69);

            	// PascalGrammar.g:140:6: ( ident_list type ( SEMICOLON )+ )+
            	int cnt16 = 0;
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == IDENT) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // PascalGrammar.g:140:7: ident_list type ( SEMICOLON )+
            			    {
            			    	PushFollow(FOLLOW_ident_list_in_variables_definition1041);
            			    	ident_list70 = ident_list();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_ident_list.Add(ident_list70.Tree);
            			    	PushFollow(FOLLOW_type_in_variables_definition1043);
            			    	type71 = type();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_type.Add(type71.Tree);
            			    	// PascalGrammar.g:140:23: ( SEMICOLON )+
            			    	int cnt15 = 0;
            			    	do 
            			    	{
            			    	    int alt15 = 2;
            			    	    int LA15_0 = input.LA(1);

            			    	    if ( (LA15_0 == SEMICOLON) )
            			    	    {
            			    	        alt15 = 1;
            			    	    }


            			    	    switch (alt15) 
            			    		{
            			    			case 1 :
            			    			    // PascalGrammar.g:0:0: SEMICOLON
            			    			    {
            			    			    	SEMICOLON72=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_variables_definition1045); if (state.failed) return retval; 
            			    			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON72);


            			    			    }
            			    			    break;

            			    			default:
            			    			    if ( cnt15 >= 1 ) goto loop15;
            			    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		            EarlyExitException eee15 =
            			    		                new EarlyExitException(15, input);
            			    		            throw eee15;
            			    	    }
            			    	    cnt15++;
            			    	} while (true);

            			    	loop15:
            			    		;	// Stops C# compiler whining that label 'loop15' has no statements


            			    }
            			    break;

            			default:
            			    if ( cnt16 >= 1 ) goto loop16;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee16 =
            		                new EarlyExitException(16, input);
            		            throw eee16;
            	    }
            	    cnt16++;
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements



            	// AST REWRITE
            	// elements:          VAR, ident_list, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 140:36: -> ^( VAR ( ^( type ident_list ) )+ )
            	{
            	    // PascalGrammar.g:140:39: ^( VAR ( ^( type ident_list ) )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

            	    if ( !(stream_ident_list.HasNext() || stream_type.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_ident_list.HasNext() || stream_type.HasNext() )
            	    {
            	        // PascalGrammar.g:140:45: ^( type ident_list )
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_2);

            	        adaptor.AddChild(root_2, stream_ident_list.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_ident_list.Reset();
            	    stream_type.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, variables_definition_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variables_definition"

    public class params_definition_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "params_definition"
    // PascalGrammar.g:143:1: params_definition : ( ident_list type ) -> ^( type ident_list ) ;
    public PascalGrammarParser.params_definition_return params_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.params_definition_return retval = new PascalGrammarParser.params_definition_return();
        retval.Start = input.LT(1);
        int params_definition_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.ident_list_return ident_list73 = default(PascalGrammarParser.ident_list_return);

        PascalGrammarParser.type_return type74 = default(PascalGrammarParser.type_return);


        RewriteRuleSubtreeStream stream_ident_list = new RewriteRuleSubtreeStream(adaptor,"rule ident_list");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:144:2: ( ( ident_list type ) -> ^( type ident_list ) )
            // PascalGrammar.g:145:2: ( ident_list type )
            {
            	// PascalGrammar.g:145:2: ( ident_list type )
            	// PascalGrammar.g:145:3: ident_list type
            	{
            		PushFollow(FOLLOW_ident_list_in_params_definition1076);
            		ident_list73 = ident_list();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_ident_list.Add(ident_list73.Tree);
            		PushFollow(FOLLOW_type_in_params_definition1078);
            		type74 = type();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_type.Add(type74.Tree);

            	}



            	// AST REWRITE
            	// elements:          ident_list, type
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 145:20: -> ^( type ident_list )
            	{
            	    // PascalGrammar.g:145:23: ^( type ident_list )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_ident_list.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, params_definition_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "params_definition"

    public class method_definition_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "method_definition"
    // PascalGrammar.g:148:1: method_definition : ( ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) | ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) );
    public PascalGrammarParser.method_definition_return method_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.method_definition_return retval = new PascalGrammarParser.method_definition_return();
        retval.Start = input.LT(1);
        int method_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken PROCEDURE75 = null;
        IToken IDENT76 = null;
        IToken char_literal77 = null;
        IToken char_literal79 = null;
        IToken char_literal81 = null;
        IToken SEMICOLON82 = null;
        IToken BLOCKOPEN85 = null;
        IToken BLOCKEND87 = null;
        IToken FUNCTION88 = null;
        IToken IDENT89 = null;
        IToken char_literal90 = null;
        IToken char_literal92 = null;
        IToken char_literal94 = null;
        IToken SEMICOLON96 = null;
        IToken BLOCKOPEN99 = null;
        IToken BLOCKEND101 = null;
        PascalGrammarParser.params_definition_return params_definition78 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.params_definition_return params_definition80 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.methods_definition_return methods_definition83 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition84 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.expr_list_return expr_list86 = default(PascalGrammarParser.expr_list_return);

        PascalGrammarParser.params_definition_return params_definition91 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.params_definition_return params_definition93 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.type_return type95 = default(PascalGrammarParser.type_return);

        PascalGrammarParser.methods_definition_return methods_definition97 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition98 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.expr_list_return expr_list100 = default(PascalGrammarParser.expr_list_return);


        object PROCEDURE75_tree=null;
        object IDENT76_tree=null;
        object char_literal77_tree=null;
        object char_literal79_tree=null;
        object char_literal81_tree=null;
        object SEMICOLON82_tree=null;
        object BLOCKOPEN85_tree=null;
        object BLOCKEND87_tree=null;
        object FUNCTION88_tree=null;
        object IDENT89_tree=null;
        object char_literal90_tree=null;
        object char_literal92_tree=null;
        object char_literal94_tree=null;
        object SEMICOLON96_tree=null;
        object BLOCKOPEN99_tree=null;
        object BLOCKEND101_tree=null;
        RewriteRuleTokenStream stream_FUNCTION = new RewriteRuleTokenStream(adaptor,"token FUNCTION");
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_PROCEDURE = new RewriteRuleTokenStream(adaptor,"token PROCEDURE");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleSubtreeStream stream_methods_definition = new RewriteRuleSubtreeStream(adaptor,"rule methods_definition");
        RewriteRuleSubtreeStream stream_variables_definition = new RewriteRuleSubtreeStream(adaptor,"rule variables_definition");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_params_definition = new RewriteRuleSubtreeStream(adaptor,"rule params_definition");
        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:149:2: ( ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) | ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) )
            int alt27 = 2;
            int LA27_0 = input.LA(1);

            if ( (LA27_0 == PROCEDURE) )
            {
                alt27 = 1;
            }
            else if ( (LA27_0 == FUNCTION) )
            {
                alt27 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d27s0 =
                    new NoViableAltException("", 27, 0, input);

                throw nvae_d27s0;
            }
            switch (alt27) 
            {
                case 1 :
                    // PascalGrammar.g:150:2: ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    {
                    	// PascalGrammar.g:150:2: ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    	// PascalGrammar.g:150:3: PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND
                    	{
                    		PROCEDURE75=(IToken)Match(input,PROCEDURE,FOLLOW_PROCEDURE_in_method_definition1102); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_PROCEDURE.Add(PROCEDURE75);

                    		IDENT76=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_method_definition1104); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT76);

                    		// PascalGrammar.g:150:19: ( '(' ( params_definition ( ';' params_definition )* )? ')' )?
                    		int alt19 = 2;
                    		int LA19_0 = input.LA(1);

                    		if ( (LA19_0 == 40) )
                    		{
                    		    alt19 = 1;
                    		}
                    		switch (alt19) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:150:20: '(' ( params_definition ( ';' params_definition )* )? ')'
                    		        {
                    		        	char_literal77=(IToken)Match(input,40,FOLLOW_40_in_method_definition1107); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_40.Add(char_literal77);

                    		        	// PascalGrammar.g:150:24: ( params_definition ( ';' params_definition )* )?
                    		        	int alt18 = 2;
                    		        	int LA18_0 = input.LA(1);

                    		        	if ( (LA18_0 == IDENT) )
                    		        	{
                    		        	    alt18 = 1;
                    		        	}
                    		        	switch (alt18) 
                    		        	{
                    		        	    case 1 :
                    		        	        // PascalGrammar.g:150:25: params_definition ( ';' params_definition )*
                    		        	        {
                    		        	        	PushFollow(FOLLOW_params_definition_in_method_definition1110);
                    		        	        	params_definition78 = params_definition();
                    		        	        	state.followingStackPointer--;
                    		        	        	if (state.failed) return retval;
                    		        	        	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition78.Tree);
                    		        	        	// PascalGrammar.g:150:43: ( ';' params_definition )*
                    		        	        	do 
                    		        	        	{
                    		        	        	    int alt17 = 2;
                    		        	        	    int LA17_0 = input.LA(1);

                    		        	        	    if ( (LA17_0 == SEMICOLON) )
                    		        	        	    {
                    		        	        	        alt17 = 1;
                    		        	        	    }


                    		        	        	    switch (alt17) 
                    		        	        		{
                    		        	        			case 1 :
                    		        	        			    // PascalGrammar.g:150:44: ';' params_definition
                    		        	        			    {
                    		        	        			    	char_literal79=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1113); if (state.failed) return retval; 
                    		        	        			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(char_literal79);

                    		        	        			    	PushFollow(FOLLOW_params_definition_in_method_definition1115);
                    		        	        			    	params_definition80 = params_definition();
                    		        	        			    	state.followingStackPointer--;
                    		        	        			    	if (state.failed) return retval;
                    		        	        			    	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition80.Tree);

                    		        	        			    }
                    		        	        			    break;

                    		        	        			default:
                    		        	        			    goto loop17;
                    		        	        	    }
                    		        	        	} while (true);

                    		        	        	loop17:
                    		        	        		;	// Stops C# compiler whining that label 'loop17' has no statements


                    		        	        }
                    		        	        break;

                    		        	}

                    		        	char_literal81=(IToken)Match(input,41,FOLLOW_41_in_method_definition1121); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_41.Add(char_literal81);


                    		        }
                    		        break;

                    		}

                    		SEMICOLON82=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1125); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON82);

                    		// PascalGrammar.g:150:86: ( methods_definition )?
                    		int alt20 = 2;
                    		int LA20_0 = input.LA(1);

                    		if ( ((LA20_0 >= FUNCTION && LA20_0 <= PROCEDURE)) )
                    		{
                    		    alt20 = 1;
                    		}
                    		switch (alt20) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:0:0: methods_definition
                    		        {
                    		        	PushFollow(FOLLOW_methods_definition_in_method_definition1127);
                    		        	methods_definition83 = methods_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition83.Tree);

                    		        }
                    		        break;

                    		}

                    		// PascalGrammar.g:151:2: ( variables_definition )?
                    		int alt21 = 2;
                    		int LA21_0 = input.LA(1);

                    		if ( (LA21_0 == VAR) )
                    		{
                    		    alt21 = 1;
                    		}
                    		switch (alt21) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:0:0: variables_definition
                    		        {
                    		        	PushFollow(FOLLOW_variables_definition_in_method_definition1132);
                    		        	variables_definition84 = variables_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition84.Tree);

                    		        }
                    		        break;

                    		}

                    		BLOCKOPEN85=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_method_definition1135); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN85);

                    		PushFollow(FOLLOW_expr_list_in_method_definition1137);
                    		expr_list86 = expr_list();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list86.Tree);
                    		BLOCKEND87=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_method_definition1139); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND87);


                    	}



                    	// AST REWRITE
                    	// elements:          PROCEDURE, params_definition, variables_definition, expr_list, methods_definition
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 152:2: -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	{
                    	    // PascalGrammar.g:152:5: ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new ProcedureAstNode(PROCEDURE, ((IDENT76 != null) ? IDENT76.Text : null)), root_1);

                    	    // PascalGrammar.g:152:48: ( ^( PARAMS ( params_definition )* ) )?
                    	    if ( stream_params_definition.HasNext() )
                    	    {
                    	        // PascalGrammar.g:152:48: ^( PARAMS ( params_definition )* )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

                    	        // PascalGrammar.g:152:57: ( params_definition )*
                    	        while ( stream_params_definition.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_2, stream_params_definition.NextTree());

                    	        }
                    	        stream_params_definition.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_params_definition.Reset();
                    	    // PascalGrammar.g:152:78: ( methods_definition )?
                    	    if ( stream_methods_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

                    	    }
                    	    stream_methods_definition.Reset();
                    	    // PascalGrammar.g:152:98: ( variables_definition )?
                    	    if ( stream_variables_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

                    	    }
                    	    stream_variables_definition.Reset();
                    	    // PascalGrammar.g:152:120: ^( BLOCK expr_list )
                    	    {
                    	    object root_2 = (object)adaptor.GetNilNode();
                    	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_2);

                    	    adaptor.AddChild(root_2, stream_expr_list.NextTree());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // PascalGrammar.g:154:2: ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    {
                    	// PascalGrammar.g:154:2: ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    	// PascalGrammar.g:154:3: FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND
                    	{
                    		FUNCTION88=(IToken)Match(input,FUNCTION,FOLLOW_FUNCTION_in_method_definition1179); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_FUNCTION.Add(FUNCTION88);

                    		IDENT89=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_method_definition1181); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT89);

                    		// PascalGrammar.g:154:18: ( '(' ( params_definition ( ';' params_definition )* )? ')' )?
                    		int alt24 = 2;
                    		int LA24_0 = input.LA(1);

                    		if ( (LA24_0 == 40) )
                    		{
                    		    alt24 = 1;
                    		}
                    		switch (alt24) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:154:19: '(' ( params_definition ( ';' params_definition )* )? ')'
                    		        {
                    		        	char_literal90=(IToken)Match(input,40,FOLLOW_40_in_method_definition1184); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_40.Add(char_literal90);

                    		        	// PascalGrammar.g:154:23: ( params_definition ( ';' params_definition )* )?
                    		        	int alt23 = 2;
                    		        	int LA23_0 = input.LA(1);

                    		        	if ( (LA23_0 == IDENT) )
                    		        	{
                    		        	    alt23 = 1;
                    		        	}
                    		        	switch (alt23) 
                    		        	{
                    		        	    case 1 :
                    		        	        // PascalGrammar.g:154:24: params_definition ( ';' params_definition )*
                    		        	        {
                    		        	        	PushFollow(FOLLOW_params_definition_in_method_definition1187);
                    		        	        	params_definition91 = params_definition();
                    		        	        	state.followingStackPointer--;
                    		        	        	if (state.failed) return retval;
                    		        	        	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition91.Tree);
                    		        	        	// PascalGrammar.g:154:42: ( ';' params_definition )*
                    		        	        	do 
                    		        	        	{
                    		        	        	    int alt22 = 2;
                    		        	        	    int LA22_0 = input.LA(1);

                    		        	        	    if ( (LA22_0 == SEMICOLON) )
                    		        	        	    {
                    		        	        	        alt22 = 1;
                    		        	        	    }


                    		        	        	    switch (alt22) 
                    		        	        		{
                    		        	        			case 1 :
                    		        	        			    // PascalGrammar.g:154:43: ';' params_definition
                    		        	        			    {
                    		        	        			    	char_literal92=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1190); if (state.failed) return retval; 
                    		        	        			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(char_literal92);

                    		        	        			    	PushFollow(FOLLOW_params_definition_in_method_definition1192);
                    		        	        			    	params_definition93 = params_definition();
                    		        	        			    	state.followingStackPointer--;
                    		        	        			    	if (state.failed) return retval;
                    		        	        			    	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition93.Tree);

                    		        	        			    }
                    		        	        			    break;

                    		        	        			default:
                    		        	        			    goto loop22;
                    		        	        	    }
                    		        	        	} while (true);

                    		        	        	loop22:
                    		        	        		;	// Stops C# compiler whining that label 'loop22' has no statements


                    		        	        }
                    		        	        break;

                    		        	}

                    		        	char_literal94=(IToken)Match(input,41,FOLLOW_41_in_method_definition1198); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_41.Add(char_literal94);


                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_type_in_method_definition1202);
                    		type95 = type();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_type.Add(type95.Tree);
                    		SEMICOLON96=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1204); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON96);

                    		// PascalGrammar.g:154:90: ( methods_definition )?
                    		int alt25 = 2;
                    		int LA25_0 = input.LA(1);

                    		if ( ((LA25_0 >= FUNCTION && LA25_0 <= PROCEDURE)) )
                    		{
                    		    alt25 = 1;
                    		}
                    		switch (alt25) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:0:0: methods_definition
                    		        {
                    		        	PushFollow(FOLLOW_methods_definition_in_method_definition1206);
                    		        	methods_definition97 = methods_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition97.Tree);

                    		        }
                    		        break;

                    		}

                    		// PascalGrammar.g:155:2: ( variables_definition )?
                    		int alt26 = 2;
                    		int LA26_0 = input.LA(1);

                    		if ( (LA26_0 == VAR) )
                    		{
                    		    alt26 = 1;
                    		}
                    		switch (alt26) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:0:0: variables_definition
                    		        {
                    		        	PushFollow(FOLLOW_variables_definition_in_method_definition1211);
                    		        	variables_definition98 = variables_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition98.Tree);

                    		        }
                    		        break;

                    		}

                    		BLOCKOPEN99=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_method_definition1214); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN99);

                    		PushFollow(FOLLOW_expr_list_in_method_definition1216);
                    		expr_list100 = expr_list();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list100.Tree);
                    		BLOCKEND101=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_method_definition1218); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND101);


                    	}



                    	// AST REWRITE
                    	// elements:          variables_definition, methods_definition, expr_list, type, params_definition, FUNCTION
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 156:2: -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	{
                    	    // PascalGrammar.g:156:5: ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new FunctionAstNode(FUNCTION, ((IDENT89 != null) ? IDENT89.Text : null), ""), root_1);

                    	    adaptor.AddChild(root_1, stream_type.NextTree());
                    	    // PascalGrammar.g:156:55: ( ^( PARAMS ( params_definition )* ) )?
                    	    if ( stream_params_definition.HasNext() )
                    	    {
                    	        // PascalGrammar.g:156:55: ^( PARAMS ( params_definition )* )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

                    	        // PascalGrammar.g:156:64: ( params_definition )*
                    	        while ( stream_params_definition.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_2, stream_params_definition.NextTree());

                    	        }
                    	        stream_params_definition.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_params_definition.Reset();
                    	    // PascalGrammar.g:156:85: ( methods_definition )?
                    	    if ( stream_methods_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

                    	    }
                    	    stream_methods_definition.Reset();
                    	    // PascalGrammar.g:156:105: ( variables_definition )?
                    	    if ( stream_variables_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

                    	    }
                    	    stream_variables_definition.Reset();
                    	    // PascalGrammar.g:156:127: ^( BLOCK expr_list )
                    	    {
                    	    object root_2 = (object)adaptor.GetNilNode();
                    	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_2);

                    	    adaptor.AddChild(root_2, stream_expr_list.NextTree());

                    	    adaptor.AddChild(root_1, root_2);
                    	    }

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, method_definition_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "method_definition"

    public class methods_definition_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "methods_definition"
    // PascalGrammar.g:159:1: methods_definition : method_definition ( SEMICOLON method_definition )* ( SEMICOLON )* -> ^( METHODS ( method_definition )* ) ;
    public PascalGrammarParser.methods_definition_return methods_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.methods_definition_return retval = new PascalGrammarParser.methods_definition_return();
        retval.Start = input.LT(1);
        int methods_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken SEMICOLON103 = null;
        IToken SEMICOLON105 = null;
        PascalGrammarParser.method_definition_return method_definition102 = default(PascalGrammarParser.method_definition_return);

        PascalGrammarParser.method_definition_return method_definition104 = default(PascalGrammarParser.method_definition_return);


        object SEMICOLON103_tree=null;
        object SEMICOLON105_tree=null;
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleSubtreeStream stream_method_definition = new RewriteRuleSubtreeStream(adaptor,"rule method_definition");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:160:2: ( method_definition ( SEMICOLON method_definition )* ( SEMICOLON )* -> ^( METHODS ( method_definition )* ) )
            // PascalGrammar.g:161:2: method_definition ( SEMICOLON method_definition )* ( SEMICOLON )*
            {
            	PushFollow(FOLLOW_method_definition_in_methods_definition1267);
            	method_definition102 = method_definition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_method_definition.Add(method_definition102.Tree);
            	// PascalGrammar.g:161:20: ( SEMICOLON method_definition )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( (LA28_0 == SEMICOLON) )
            	    {
            	        int LA28_1 = input.LA(2);

            	        if ( ((LA28_1 >= FUNCTION && LA28_1 <= PROCEDURE)) )
            	        {
            	            alt28 = 1;
            	        }


            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // PascalGrammar.g:161:21: SEMICOLON method_definition
            			    {
            			    	SEMICOLON103=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_methods_definition1270); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON103);

            			    	PushFollow(FOLLOW_method_definition_in_methods_definition1272);
            			    	method_definition104 = method_definition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_method_definition.Add(method_definition104.Tree);

            			    }
            			    break;

            			default:
            			    goto loop28;
            	    }
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements

            	// PascalGrammar.g:161:51: ( SEMICOLON )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == SEMICOLON) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // PascalGrammar.g:0:0: SEMICOLON
            			    {
            			    	SEMICOLON105=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_methods_definition1276); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON105);


            			    }
            			    break;

            			default:
            			    goto loop29;
            	    }
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements



            	// AST REWRITE
            	// elements:          method_definition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 161:62: -> ^( METHODS ( method_definition )* )
            	{
            	    // PascalGrammar.g:161:65: ^( METHODS ( method_definition )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METHODS, "METHODS"), root_1);

            	    // PascalGrammar.g:161:75: ( method_definition )*
            	    while ( stream_method_definition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_method_definition.NextTree());

            	    }
            	    stream_method_definition.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, methods_definition_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "methods_definition"

    public class program_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // PascalGrammar.g:164:1: program : PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.' -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body ) ;
    public PascalGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        PascalGrammarParser.program_return retval = new PascalGrammarParser.program_return();
        retval.Start = input.LT(1);
        int program_StartIndex = input.Index();
        object root_0 = null;

        IToken PROGRAM106 = null;
        IToken IDENT107 = null;
        IToken SEMICOLON108 = null;
        IToken BLOCKOPEN111 = null;
        IToken BLOCKEND113 = null;
        IToken char_literal114 = null;
        PascalGrammarParser.methods_definition_return methods_definition109 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition110 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.program_body_return program_body112 = default(PascalGrammarParser.program_body_return);


        object PROGRAM106_tree=null;
        object IDENT107_tree=null;
        object SEMICOLON108_tree=null;
        object BLOCKOPEN111_tree=null;
        object BLOCKEND113_tree=null;
        object char_literal114_tree=null;
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_PROGRAM = new RewriteRuleTokenStream(adaptor,"token PROGRAM");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleSubtreeStream stream_methods_definition = new RewriteRuleSubtreeStream(adaptor,"rule methods_definition");
        RewriteRuleSubtreeStream stream_program_body = new RewriteRuleSubtreeStream(adaptor,"rule program_body");
        RewriteRuleSubtreeStream stream_variables_definition = new RewriteRuleSubtreeStream(adaptor,"rule variables_definition");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:165:2: ( PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.' -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body ) )
            // PascalGrammar.g:166:2: PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.'
            {
            	PROGRAM106=(IToken)Match(input,PROGRAM,FOLLOW_PROGRAM_in_program1303); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PROGRAM.Add(PROGRAM106);

            	IDENT107=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_program1305); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT107);

            	SEMICOLON108=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_program1307); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON108);

            	// PascalGrammar.g:166:26: ( methods_definition )?
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( ((LA30_0 >= FUNCTION && LA30_0 <= PROCEDURE)) )
            	{
            	    alt30 = 1;
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:0:0: methods_definition
            	        {
            	        	PushFollow(FOLLOW_methods_definition_in_program1309);
            	        	methods_definition109 = methods_definition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition109.Tree);

            	        }
            	        break;

            	}

            	// PascalGrammar.g:166:46: ( variables_definition )?
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == VAR) )
            	{
            	    alt31 = 1;
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:0:0: variables_definition
            	        {
            	        	PushFollow(FOLLOW_variables_definition_in_program1312);
            	        	variables_definition110 = variables_definition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition110.Tree);

            	        }
            	        break;

            	}

            	BLOCKOPEN111=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_program1316); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN111);

            	PushFollow(FOLLOW_program_body_in_program1318);
            	program_body112 = program_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_program_body.Add(program_body112.Tree);
            	BLOCKEND113=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_program1320); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND113);

            	char_literal114=(IToken)Match(input,44,FOLLOW_44_in_program1322); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal114);



            	// AST REWRITE
            	// elements:          PROGRAM, program_body, methods_definition, variables_definition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 167:3: -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body )
            	{
            	    // PascalGrammar.g:167:6: ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ProgAstNode(PROGRAM, ((IDENT107 != null) ? IDENT107.Text : null)), root_1);

            	    // PascalGrammar.g:167:42: ( methods_definition )?
            	    if ( stream_methods_definition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

            	    }
            	    stream_methods_definition.Reset();
            	    // PascalGrammar.g:167:62: ( variables_definition )?
            	    if ( stream_variables_definition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

            	    }
            	    stream_variables_definition.Reset();
            	    adaptor.AddChild(root_1, stream_program_body.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, program_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "program"

    public class result_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "result"
    // PascalGrammar.g:170:1: result : program ;
    public PascalGrammarParser.result_return result() // throws RecognitionException [1]
    {   
        PascalGrammarParser.result_return retval = new PascalGrammarParser.result_return();
        retval.Start = input.LT(1);
        int result_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.program_return program115 = default(PascalGrammarParser.program_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:171:2: ( program )
            // PascalGrammar.g:172:2: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_result1360);
            	program115 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program115.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, result_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "result"

    public class execute_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "execute"
    // PascalGrammar.g:175:1: execute : result ;
    public PascalGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        PascalGrammarParser.execute_return retval = new PascalGrammarParser.execute_return();
        retval.Start = input.LT(1);
        int execute_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.result_return result116 = default(PascalGrammarParser.result_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:176:2: ( result )
            // PascalGrammar.g:177:2: result
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_result_in_execute1378);
            	result116 = result();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result116.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, execute_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "execute"

    // $ANTLR start "synpred21_PascalGrammar"
    public void synpred21_PascalGrammar_fragment() {
        // PascalGrammar.g:113:28: ( ELSE expr )
        // PascalGrammar.g:113:28: ELSE expr
        {
        	Match(input,ELSE,FOLLOW_ELSE_in_synpred21_PascalGrammar864); if (state.failed) return ;
        	PushFollow(FOLLOW_expr_in_synpred21_PascalGrammar867);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred21_PascalGrammar"

    // Delegated rules

   	public bool synpred21_PascalGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred21_PascalGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA9 dfa9;
   	protected DFA12 dfa12;
	private void InitializeCyclicDFAs()
	{
    	this.dfa9 = new DFA9(this);
    	this.dfa12 = new DFA12(this);
	}

    const string DFA9_eotS =
        "\x0a\uffff";
    const string DFA9_eofS =
        "\x01\uffff\x01\x09\x08\uffff";
    const string DFA9_minS =
        "\x01\x0b\x01\x0a\x08\uffff";
    const string DFA9_maxS =
        "\x01\x1d\x01\x28\x08\uffff";
    const string DFA9_acceptS =
        "\x02\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x02\x01"+
        "\x03\x01\x01";
    const string DFA9_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA9_transitionS = {
            "\x01\x02\x05\uffff\x01\x03\x02\uffff\x01\x04\x01\uffff\x01"+
            "\x06\x01\x05\x05\uffff\x01\x01",
            "\x01\x09\x01\uffff\x01\x09\x06\uffff\x01\x09\x03\uffff\x01"+
            "\x09\x0e\uffff\x01\x07\x01\uffff\x01\x08",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
    static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
    static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
    static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
    static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
    static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
    static readonly short[][] DFA9_transition = DFA.UnpackEncodedStringArray(DFA9_transitionS);

    protected class DFA9 : DFA
    {
        public DFA9(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;

        }

        override public string Description
        {
            get { return "108:1: expr : ( IDENT | IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare );"; }
        }

    }

    const string DFA12_eotS =
        "\x04\uffff";
    const string DFA12_eofS =
        "\x04\uffff";
    const string DFA12_minS =
        "\x02\x0a\x02\uffff";
    const string DFA12_maxS =
        "\x01\x0c\x01\x1d\x02\uffff";
    const string DFA12_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA12_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x01\x01\uffff\x01\x02",
            "\x01\x01\x01\x03\x01\x02\x04\uffff\x01\x03\x02\uffff\x01\x03"+
            "\x01\uffff\x02\x03\x05\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 121:15: ( ( ';' )+ expr )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_40_in_group591 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_term_in_group594 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_group596 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_group602 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOLEAN_in_group615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_group620 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_group625 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_group630 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_denial651 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_group_in_denial655 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_denial_in_mult667 = new BitSet(new ulong[]{0x0000003001000002UL});
    public static readonly BitSet FOLLOW_set_in_mult671 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_denial_in_mult686 = new BitSet(new ulong[]{0x0000003001000002UL});
    public static readonly BitSet FOLLOW_mult_in_add698 = new BitSet(new ulong[]{0x0000000C06000002UL});
    public static readonly BitSet FOLLOW_set_in_add703 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_mult_in_add722 = new BitSet(new ulong[]{0x0000000C06000002UL});
    public static readonly BitSet FOLLOW_add_in_compare735 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_COMPARE_in_compare739 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_add_in_compare742 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_compare_in_term751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_arg_list760 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_42_in_arg_list763 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_term_in_arg_list766 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_func_call782 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_func_call785 = new BitSet(new ulong[]{0x0000030178000000UL});
    public static readonly BitSet FOLLOW_arg_list_in_func_call787 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_func_call789 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr817 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr821 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr823 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_term_in_expr826 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_expr831 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_expr836 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_expr838 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_expr840 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_expr853 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr856 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_THEN_in_expr858 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr861 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_ELSE_in_expr864 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr867 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr874 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr877 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr879 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_add_in_expr882 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_TO_in_expr884 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_add_in_expr887 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_DO_in_expr889 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr892 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr897 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr900 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_DO_in_expr902 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DO_in_expr910 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr913 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr915 = new BitSet(new ulong[]{0x0000010178000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr918 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list936 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr_list941 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list946 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr_list951 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list957 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_expr_list_in_program_body974 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident_list996 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_42_in_ident_list999 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident_list1002 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_43_in_type1017 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_type1019 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_in_variables_definition1038 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_ident_list_in_variables_definition1041 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_type_in_variables_definition1043 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_variables_definition1045 = new BitSet(new ulong[]{0x0000000020000402UL});
    public static readonly BitSet FOLLOW_ident_list_in_params_definition1076 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_type_in_params_definition1078 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PROCEDURE_in_method_definition1102 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_method_definition1104 = new BitSet(new ulong[]{0x0000010000000400UL});
    public static readonly BitSet FOLLOW_40_in_method_definition1107 = new BitSet(new ulong[]{0x0000020020000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1110 = new BitSet(new ulong[]{0x0000020000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1113 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1115 = new BitSet(new ulong[]{0x0000020000000400UL});
    public static readonly BitSet FOLLOW_41_in_method_definition1121 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1125 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_method_definition1127 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_method_definition1132 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_method_definition1135 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_method_definition1137 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_method_definition1139 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNCTION_in_method_definition1179 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_method_definition1181 = new BitSet(new ulong[]{0x0000090000000000UL});
    public static readonly BitSet FOLLOW_40_in_method_definition1184 = new BitSet(new ulong[]{0x0000020020000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1187 = new BitSet(new ulong[]{0x0000020000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1190 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1192 = new BitSet(new ulong[]{0x0000020000000400UL});
    public static readonly BitSet FOLLOW_41_in_method_definition1198 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_type_in_method_definition1202 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1204 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_method_definition1206 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_method_definition1211 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_method_definition1214 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_method_definition1216 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_method_definition1218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_method_definition_in_methods_definition1267 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_methods_definition1270 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_method_definition_in_methods_definition1272 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_methods_definition1276 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_PROGRAM_in_program1303 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_program1305 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_program1307 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_program1309 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_program1312 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_program1316 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_program_body_in_program1318 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_program1320 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_program1322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_result1360 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_result_in_execute1378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_synpred21_PascalGrammar864 = new BitSet(new ulong[]{0x0000000020D20C00UL});
    public static readonly BitSet FOLLOW_expr_in_synpred21_PascalGrammar867 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}