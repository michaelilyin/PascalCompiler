// $ANTLR 3.2 Sep 23, 2009 12:02:23 PascalGrammar.g 2013-10-27 21:35:57

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
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int XOR = 25;
    public const int WHILE = 22;
    public const int TO = 20;
    public const int ELSE = 18;
    public const int NUMBER = 28;
    public const int DO = 21;
    public const int FOR = 19;
    public const int SUB = 33;
    public const int SEMICOLON = 10;
    public const int AND = 23;
    public const int EOF = -1;
    public const int MUL = 34;
    public const int PROCEDURE = 14;
    public const int IF = 16;
    public const int FUNC_CALL = 15;
    public const int BLOCKOPEN = 11;
    public const int WS = 31;
    public const int BOOLEAN = 26;
    public const int THEN = 17;
    public const int METHODS = 8;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int STRING_CONST = 9;
    public const int BLOCK = 6;
    public const int BLOCKEND = 12;
    public const int OR = 24;
    public const int ASSIGN = 36;
    public const int COMPARE = 37;
    public const int IDENT = 27;
    public const int PROGRAM = 4;
    public const int VAR = 5;
    public const int DIV = 35;
    public const int COMMENT = 29;
    public const int STRING = 30;
    public const int ADD = 32;
    public const int PARAMS = 7;

    // delegates
    // delegators



        public PascalGrammarParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PascalGrammarParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[64+1];
             
             
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
    // PascalGrammar.g:83:1: group : ( '(' term ')' | NUMBER -> NUMBER[double.Parse($NUMBER.text, NFI)] | BOOLEAN | func_call | IDENT | STRING -> STRING[$STRING.text] );
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
            // PascalGrammar.g:84:2: ( '(' term ')' | NUMBER -> NUMBER[double.Parse($NUMBER.text, NFI)] | BOOLEAN | func_call | IDENT | STRING -> STRING[$STRING.text] )
            int alt1 = 6;
            switch ( input.LA(1) ) 
            {
            case 38:
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

                if ( (LA1_4 == EOF || LA1_4 == SEMICOLON || LA1_4 == BLOCKEND || (LA1_4 >= THEN && LA1_4 <= ELSE) || (LA1_4 >= TO && LA1_4 <= XOR) || (LA1_4 >= ADD && LA1_4 <= DIV) || LA1_4 == COMPARE || (LA1_4 >= 39 && LA1_4 <= 40)) )
                {
                    alt1 = 5;
                }
                else if ( (LA1_4 == 38) )
                {
                    alt1 = 4;
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
                    // PascalGrammar.g:85:2: '(' term ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal1=(IToken)Match(input,38,FOLLOW_38_in_group575); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_group578);
                    	term2 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
                    	char_literal3=(IToken)Match(input,39,FOLLOW_39_in_group580); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:86:4: NUMBER
                    {
                    	NUMBER4=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_group586); if (state.failed) return retval; 
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
                    	// 86:11: -> NUMBER[double.Parse($NUMBER.text, NFI)]
                    	{
                    	    adaptor.AddChild(root_0, new NumAstNode(NUMBER, double.Parse(((NUMBER4 != null) ? NUMBER4.Text : null), NFI)));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // PascalGrammar.g:87:4: BOOLEAN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BOOLEAN5=(IToken)Match(input,BOOLEAN,FOLLOW_BOOLEAN_in_group599); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BOOLEAN5_tree = (object)adaptor.Create(BOOLEAN5);
                    		adaptor.AddChild(root_0, BOOLEAN5_tree);
                    	}

                    }
                    break;
                case 4 :
                    // PascalGrammar.g:88:4: func_call
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_group604);
                    	func_call6 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call6.Tree);

                    }
                    break;
                case 5 :
                    // PascalGrammar.g:89:4: IDENT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT7=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_group609); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT7_tree = (object)adaptor.Create(IDENT7);
                    		adaptor.AddChild(root_0, IDENT7_tree);
                    	}

                    }
                    break;
                case 6 :
                    // PascalGrammar.g:90:4: STRING
                    {
                    	STRING8=(IToken)Match(input,STRING,FOLLOW_STRING_in_group614); if (state.failed) return retval; 
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
                    	// 90:11: -> STRING[$STRING.text]
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
    // PascalGrammar.g:93:1: mult : group ( ( MUL | DIV | AND ) group )* ;
    public PascalGrammarParser.mult_return mult() // throws RecognitionException [1]
    {   
        PascalGrammarParser.mult_return retval = new PascalGrammarParser.mult_return();
        retval.Start = input.LT(1);
        int mult_StartIndex = input.Index();
        object root_0 = null;

        IToken set10 = null;
        PascalGrammarParser.group_return group9 = default(PascalGrammarParser.group_return);

        PascalGrammarParser.group_return group11 = default(PascalGrammarParser.group_return);


        object set10_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:93:5: ( group ( ( MUL | DIV | AND ) group )* )
            // PascalGrammar.g:93:7: group ( ( MUL | DIV | AND ) group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult637);
            	group9 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group9.Tree);
            	// PascalGrammar.g:93:13: ( ( MUL | DIV | AND ) group )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == AND || (LA2_0 >= MUL && LA2_0 <= DIV)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // PascalGrammar.g:93:15: ( MUL | DIV | AND ) group
            			    {
            			    	set10=(IToken)input.LT(1);
            			    	set10 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == AND || (input.LA(1) >= MUL && input.LA(1) <= DIV) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set10), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_group_in_mult656);
            			    	group11 = group();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group11.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


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
            	Memoize(input, 2, mult_StartIndex); 
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
    // PascalGrammar.g:94:1: add : mult ( ( ADD | SUB | OR | XOR ) mult )* ;
    public PascalGrammarParser.add_return add() // throws RecognitionException [1]
    {   
        PascalGrammarParser.add_return retval = new PascalGrammarParser.add_return();
        retval.Start = input.LT(1);
        int add_StartIndex = input.Index();
        object root_0 = null;

        IToken set13 = null;
        PascalGrammarParser.mult_return mult12 = default(PascalGrammarParser.mult_return);

        PascalGrammarParser.mult_return mult14 = default(PascalGrammarParser.mult_return);


        object set13_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:94:4: ( mult ( ( ADD | SUB | OR | XOR ) mult )* )
            // PascalGrammar.g:94:7: mult ( ( ADD | SUB | OR | XOR ) mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add668);
            	mult12 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult12.Tree);
            	// PascalGrammar.g:94:13: ( ( ADD | SUB | OR | XOR ) mult )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= OR && LA3_0 <= XOR) || (LA3_0 >= ADD && LA3_0 <= SUB)) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // PascalGrammar.g:94:15: ( ADD | SUB | OR | XOR ) mult
            			    {
            			    	set13=(IToken)input.LT(1);
            			    	set13 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= OR && input.LA(1) <= XOR) || (input.LA(1) >= ADD && input.LA(1) <= SUB) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set13), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_mult_in_add692);
            			    	mult14 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult14.Tree);

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
            	Memoize(input, 3, add_StartIndex); 
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
    // PascalGrammar.g:95:1: compare : add ( COMPARE add )* ;
    public PascalGrammarParser.compare_return compare() // throws RecognitionException [1]
    {   
        PascalGrammarParser.compare_return retval = new PascalGrammarParser.compare_return();
        retval.Start = input.LT(1);
        int compare_StartIndex = input.Index();
        object root_0 = null;

        IToken COMPARE16 = null;
        PascalGrammarParser.add_return add15 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.add_return add17 = default(PascalGrammarParser.add_return);


        object COMPARE16_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:95:9: ( add ( COMPARE add )* )
            // PascalGrammar.g:95:11: add ( COMPARE add )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_compare705);
            	add15 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add15.Tree);
            	// PascalGrammar.g:95:15: ( COMPARE add )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == COMPARE) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // PascalGrammar.g:95:17: COMPARE add
            			    {
            			    	COMPARE16=(IToken)Match(input,COMPARE,FOLLOW_COMPARE_in_compare709); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMPARE16_tree = (object)adaptor.Create(COMPARE16);
            			    		root_0 = (object)adaptor.BecomeRoot(COMPARE16_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_add_in_compare712);
            			    	add17 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add17.Tree);

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
            	Memoize(input, 4, compare_StartIndex); 
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
    // PascalGrammar.g:96:1: term : compare ;
    public PascalGrammarParser.term_return term() // throws RecognitionException [1]
    {   
        PascalGrammarParser.term_return retval = new PascalGrammarParser.term_return();
        retval.Start = input.LT(1);
        int term_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.compare_return compare18 = default(PascalGrammarParser.compare_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:96:6: ( compare )
            // PascalGrammar.g:96:8: compare
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_compare_in_term721);
            	compare18 = compare();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare18.Tree);

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
            	Memoize(input, 5, term_StartIndex); 
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
    // PascalGrammar.g:98:1: arg_list : ( term ( ',' term )* )? ;
    public PascalGrammarParser.arg_list_return arg_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.arg_list_return retval = new PascalGrammarParser.arg_list_return();
        retval.Start = input.LT(1);
        int arg_list_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal20 = null;
        PascalGrammarParser.term_return term19 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.term_return term21 = default(PascalGrammarParser.term_return);


        object char_literal20_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:98:9: ( ( term ( ',' term )* )? )
            // PascalGrammar.g:98:11: ( term ( ',' term )* )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// PascalGrammar.g:98:11: ( term ( ',' term )* )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( ((LA6_0 >= BOOLEAN && LA6_0 <= NUMBER) || LA6_0 == STRING || LA6_0 == 38) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:98:13: term ( ',' term )*
            	        {
            	        	PushFollow(FOLLOW_term_in_arg_list730);
            	        	term19 = term();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term19.Tree);
            	        	// PascalGrammar.g:98:18: ( ',' term )*
            	        	do 
            	        	{
            	        	    int alt5 = 2;
            	        	    int LA5_0 = input.LA(1);

            	        	    if ( (LA5_0 == 40) )
            	        	    {
            	        	        alt5 = 1;
            	        	    }


            	        	    switch (alt5) 
            	        		{
            	        			case 1 :
            	        			    // PascalGrammar.g:98:19: ',' term
            	        			    {
            	        			    	char_literal20=(IToken)Match(input,40,FOLLOW_40_in_arg_list733); if (state.failed) return retval;
            	        			    	PushFollow(FOLLOW_term_in_arg_list736);
            	        			    	term21 = term();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term21.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop5;
            	        	    }
            	        	} while (true);

            	        	loop5:
            	        		;	// Stops C# compiler whining that label 'loop5' has no statements


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
            	Memoize(input, 6, arg_list_StartIndex); 
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
    // PascalGrammar.g:100:1: func_call : IDENT ( '(' arg_list ')' ) -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? ) ;
    public PascalGrammarParser.func_call_return func_call() // throws RecognitionException [1]
    {   
        PascalGrammarParser.func_call_return retval = new PascalGrammarParser.func_call_return();
        retval.Start = input.LT(1);
        int func_call_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT22 = null;
        IToken char_literal23 = null;
        IToken char_literal25 = null;
        PascalGrammarParser.arg_list_return arg_list24 = default(PascalGrammarParser.arg_list_return);


        object IDENT22_tree=null;
        object char_literal23_tree=null;
        object char_literal25_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_arg_list = new RewriteRuleSubtreeStream(adaptor,"rule arg_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:101:2: ( IDENT ( '(' arg_list ')' ) -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? ) )
            // PascalGrammar.g:102:2: IDENT ( '(' arg_list ')' )
            {
            	IDENT22=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_func_call752); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT22);

            	// PascalGrammar.g:102:8: ( '(' arg_list ')' )
            	// PascalGrammar.g:102:9: '(' arg_list ')'
            	{
            		char_literal23=(IToken)Match(input,38,FOLLOW_38_in_func_call755); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_38.Add(char_literal23);

            		PushFollow(FOLLOW_arg_list_in_func_call757);
            		arg_list24 = arg_list();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_arg_list.Add(arg_list24.Tree);
            		char_literal25=(IToken)Match(input,39,FOLLOW_39_in_func_call759); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_39.Add(char_literal25);


            	}



            	// AST REWRITE
            	// elements:          IDENT, arg_list
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 102:28: -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? )
            	{
            	    // PascalGrammar.g:102:31: ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // PascalGrammar.g:102:49: ( ^( PARAMS arg_list ) )?
            	    if ( stream_arg_list.HasNext() )
            	    {
            	        // PascalGrammar.g:102:49: ^( PARAMS arg_list )
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
            	Memoize(input, 7, func_call_StartIndex); 
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
    // PascalGrammar.g:105:1: expr : ( IDENT | IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare );
    public PascalGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        PascalGrammarParser.expr_return retval = new PascalGrammarParser.expr_return();
        retval.Start = input.LT(1);
        int expr_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT26 = null;
        IToken IDENT27 = null;
        IToken ASSIGN28 = null;
        IToken BLOCKOPEN31 = null;
        IToken BLOCKEND33 = null;
        IToken IF34 = null;
        IToken THEN36 = null;
        IToken ELSE38 = null;
        IToken FOR40 = null;
        IToken IDENT41 = null;
        IToken ASSIGN42 = null;
        IToken TO44 = null;
        IToken DO46 = null;
        IToken WHILE48 = null;
        IToken DO50 = null;
        IToken DO52 = null;
        IToken WHILE54 = null;
        PascalGrammarParser.term_return term29 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.func_call_return func_call30 = default(PascalGrammarParser.func_call_return);

        PascalGrammarParser.expr_list_return expr_list32 = default(PascalGrammarParser.expr_list_return);

        PascalGrammarParser.compare_return compare35 = default(PascalGrammarParser.compare_return);

        PascalGrammarParser.expr_return expr37 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr39 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.add_return add43 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.add_return add45 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.expr_return expr47 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.compare_return compare49 = default(PascalGrammarParser.compare_return);

        PascalGrammarParser.expr_return expr51 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr53 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.compare_return compare55 = default(PascalGrammarParser.compare_return);


        object IDENT26_tree=null;
        object IDENT27_tree=null;
        object ASSIGN28_tree=null;
        object BLOCKOPEN31_tree=null;
        object BLOCKEND33_tree=null;
        object IF34_tree=null;
        object THEN36_tree=null;
        object ELSE38_tree=null;
        object FOR40_tree=null;
        object IDENT41_tree=null;
        object ASSIGN42_tree=null;
        object TO44_tree=null;
        object DO46_tree=null;
        object WHILE48_tree=null;
        object DO50_tree=null;
        object DO52_tree=null;
        object WHILE54_tree=null;
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:105:6: ( IDENT | IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare )
            int alt8 = 8;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // PascalGrammar.g:106:2: IDENT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT26=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr787); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT26_tree = (object)adaptor.Create(IDENT26);
                    		adaptor.AddChild(root_0, IDENT26_tree);
                    	}

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:107:3: IDENT ASSIGN term
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT27=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr791); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT27_tree = (object)adaptor.Create(IDENT27);
                    		adaptor.AddChild(root_0, IDENT27_tree);
                    	}
                    	ASSIGN28=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr793); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN28_tree = (object)adaptor.Create(ASSIGN28);
                    		root_0 = (object)adaptor.BecomeRoot(ASSIGN28_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr796);
                    	term29 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term29.Tree);

                    }
                    break;
                case 3 :
                    // PascalGrammar.g:108:4: func_call
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_expr801);
                    	func_call30 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call30.Tree);

                    }
                    break;
                case 4 :
                    // PascalGrammar.g:109:4: BLOCKOPEN expr_list BLOCKEND
                    {
                    	BLOCKOPEN31=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_expr806); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN31);

                    	PushFollow(FOLLOW_expr_list_in_expr808);
                    	expr_list32 = expr_list();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list32.Tree);
                    	BLOCKEND33=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_expr810); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND33);



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
                    	// 109:33: -> ^( BLOCK expr_list )
                    	{
                    	    // PascalGrammar.g:109:36: ^( BLOCK expr_list )
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
                    // PascalGrammar.g:110:4: IF compare THEN expr ( ELSE expr )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IF34=(IToken)Match(input,IF,FOLLOW_IF_in_expr823); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IF34_tree = (object)adaptor.Create(IF34);
                    		root_0 = (object)adaptor.BecomeRoot(IF34_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_compare_in_expr826);
                    	compare35 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare35.Tree);
                    	THEN36=(IToken)Match(input,THEN,FOLLOW_THEN_in_expr828); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr831);
                    	expr37 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr37.Tree);
                    	// PascalGrammar.g:110:27: ( ELSE expr )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == ELSE) )
                    	{
                    	    int LA7_1 = input.LA(2);

                    	    if ( (synpred20_PascalGrammar()) )
                    	    {
                    	        alt7 = 1;
                    	    }
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // PascalGrammar.g:110:28: ELSE expr
                    	        {
                    	        	ELSE38=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_expr834); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_expr_in_expr837);
                    	        	expr39 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr39.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 6 :
                    // PascalGrammar.g:111:4: FOR IDENT ASSIGN add TO add DO expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FOR40=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr844); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FOR40_tree = (object)adaptor.Create(FOR40);
                    		root_0 = (object)adaptor.BecomeRoot(FOR40_tree, root_0);
                    	}
                    	IDENT41=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr847); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT41_tree = (object)adaptor.Create(IDENT41);
                    		adaptor.AddChild(root_0, IDENT41_tree);
                    	}
                    	ASSIGN42=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr849); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_expr852);
                    	add43 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add43.Tree);
                    	TO44=(IToken)Match(input,TO,FOLLOW_TO_in_expr854); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_expr857);
                    	add45 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add45.Tree);
                    	DO46=(IToken)Match(input,DO,FOLLOW_DO_in_expr859); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr862);
                    	expr47 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr47.Tree);

                    }
                    break;
                case 7 :
                    // PascalGrammar.g:112:4: WHILE compare DO expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	WHILE48=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr867); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WHILE48_tree = (object)adaptor.Create(WHILE48);
                    		root_0 = (object)adaptor.BecomeRoot(WHILE48_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_compare_in_expr870);
                    	compare49 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare49.Tree);
                    	DO50=(IToken)Match(input,DO,FOLLOW_DO_in_expr872); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr875);
                    	expr51 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr51.Tree);

                    }
                    break;
                case 8 :
                    // PascalGrammar.g:113:4: DO expr WHILE compare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	DO52=(IToken)Match(input,DO,FOLLOW_DO_in_expr880); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DO52_tree = (object)adaptor.Create(DO52);
                    		root_0 = (object)adaptor.BecomeRoot(DO52_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_expr_in_expr883);
                    	expr53 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr53.Tree);
                    	WHILE54=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr885); if (state.failed) return retval;
                    	PushFollow(FOLLOW_compare_in_expr888);
                    	compare55 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare55.Tree);

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
            	Memoize(input, 8, expr_StartIndex); 
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
    // PascalGrammar.g:116:1: expr_list : ( ';' )* expr ( ( ';' )+ expr )* ( ';' )* ;
    public PascalGrammarParser.expr_list_return expr_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.expr_list_return retval = new PascalGrammarParser.expr_list_return();
        retval.Start = input.LT(1);
        int expr_list_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal56 = null;
        IToken char_literal58 = null;
        IToken char_literal60 = null;
        PascalGrammarParser.expr_return expr57 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr59 = default(PascalGrammarParser.expr_return);


        object char_literal56_tree=null;
        object char_literal58_tree=null;
        object char_literal60_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:117:2: ( ( ';' )* expr ( ( ';' )+ expr )* ( ';' )* )
            // PascalGrammar.g:118:2: ( ';' )* expr ( ( ';' )+ expr )* ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// PascalGrammar.g:118:2: ( ';' )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == SEMICOLON) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // PascalGrammar.g:118:3: ';'
            			    {
            			    	char_literal56=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list906); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	PushFollow(FOLLOW_expr_in_expr_list911);
            	expr57 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr57.Tree);
            	// PascalGrammar.g:118:15: ( ( ';' )+ expr )*
            	do 
            	{
            	    int alt11 = 2;
            	    alt11 = dfa11.Predict(input);
            	    switch (alt11) 
            		{
            			case 1 :
            			    // PascalGrammar.g:118:17: ( ';' )+ expr
            			    {
            			    	// PascalGrammar.g:118:17: ( ';' )+
            			    	int cnt10 = 0;
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
            			    			    // PascalGrammar.g:118:18: ';'
            			    			    {
            			    			    	char_literal58=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list916); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    if ( cnt10 >= 1 ) goto loop10;
            			    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		            EarlyExitException eee10 =
            			    		                new EarlyExitException(10, input);
            			    		            throw eee10;
            			    	    }
            			    	    cnt10++;
            			    	} while (true);

            			    	loop10:
            			    		;	// Stops C# compiler whining that label 'loop10' has no statements

            			    	PushFollow(FOLLOW_expr_in_expr_list921);
            			    	expr59 = expr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr59.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	// PascalGrammar.g:118:33: ( ';' )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == SEMICOLON) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // PascalGrammar.g:118:34: ';'
            			    {
            			    	char_literal60=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list927); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


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
            	Memoize(input, 9, expr_list_StartIndex); 
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
    // PascalGrammar.g:121:1: program_body : expr_list -> ^( BLOCK expr_list ) ;
    public PascalGrammarParser.program_body_return program_body() // throws RecognitionException [1]
    {   
        PascalGrammarParser.program_body_return retval = new PascalGrammarParser.program_body_return();
        retval.Start = input.LT(1);
        int program_body_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.expr_list_return expr_list61 = default(PascalGrammarParser.expr_list_return);


        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:122:2: ( expr_list -> ^( BLOCK expr_list ) )
            // PascalGrammar.g:123:2: expr_list
            {
            	PushFollow(FOLLOW_expr_list_in_program_body944);
            	expr_list61 = expr_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list61.Tree);


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
            	// 123:12: -> ^( BLOCK expr_list )
            	{
            	    // PascalGrammar.g:123:15: ^( BLOCK expr_list )
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
            	Memoize(input, 10, program_body_StartIndex); 
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
    // PascalGrammar.g:126:1: ident_list : IDENT ( ',' IDENT )* ;
    public PascalGrammarParser.ident_list_return ident_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.ident_list_return retval = new PascalGrammarParser.ident_list_return();
        retval.Start = input.LT(1);
        int ident_list_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT62 = null;
        IToken char_literal63 = null;
        IToken IDENT64 = null;

        object IDENT62_tree=null;
        object char_literal63_tree=null;
        object IDENT64_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:127:2: ( IDENT ( ',' IDENT )* )
            // PascalGrammar.g:128:2: IDENT ( ',' IDENT )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IDENT62=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident_list966); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IDENT62_tree = (object)adaptor.Create(IDENT62);
            		adaptor.AddChild(root_0, IDENT62_tree);
            	}
            	// PascalGrammar.g:128:8: ( ',' IDENT )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == 40) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // PascalGrammar.g:128:9: ',' IDENT
            			    {
            			    	char_literal63=(IToken)Match(input,40,FOLLOW_40_in_ident_list969); if (state.failed) return retval;
            			    	IDENT64=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident_list972); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{IDENT64_tree = (object)adaptor.Create(IDENT64);
            			    		adaptor.AddChild(root_0, IDENT64_tree);
            			    	}

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
            	Memoize(input, 11, ident_list_StartIndex); 
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
    // PascalGrammar.g:131:1: type : ':' IDENT -> ^( IDENT ) ;
    public PascalGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        PascalGrammarParser.type_return retval = new PascalGrammarParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal65 = null;
        IToken IDENT66 = null;

        object char_literal65_tree=null;
        object IDENT66_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:131:6: ( ':' IDENT -> ^( IDENT ) )
            // PascalGrammar.g:132:2: ':' IDENT
            {
            	char_literal65=(IToken)Match(input,41,FOLLOW_41_in_type987); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal65);

            	IDENT66=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_type989); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT66);



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
            	// 132:12: -> ^( IDENT )
            	{
            	    // PascalGrammar.g:132:15: ^( IDENT )
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
            	Memoize(input, 12, type_StartIndex); 
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
    // PascalGrammar.g:135:1: variables_definition : VAR ( ident_list type ( SEMICOLON )+ )+ -> ^( VAR ( ^( type ident_list ) )+ ) ;
    public PascalGrammarParser.variables_definition_return variables_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.variables_definition_return retval = new PascalGrammarParser.variables_definition_return();
        retval.Start = input.LT(1);
        int variables_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken VAR67 = null;
        IToken SEMICOLON70 = null;
        PascalGrammarParser.ident_list_return ident_list68 = default(PascalGrammarParser.ident_list_return);

        PascalGrammarParser.type_return type69 = default(PascalGrammarParser.type_return);


        object VAR67_tree=null;
        object SEMICOLON70_tree=null;
        RewriteRuleTokenStream stream_VAR = new RewriteRuleTokenStream(adaptor,"token VAR");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleSubtreeStream stream_ident_list = new RewriteRuleSubtreeStream(adaptor,"rule ident_list");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:136:2: ( VAR ( ident_list type ( SEMICOLON )+ )+ -> ^( VAR ( ^( type ident_list ) )+ ) )
            // PascalGrammar.g:137:2: VAR ( ident_list type ( SEMICOLON )+ )+
            {
            	VAR67=(IToken)Match(input,VAR,FOLLOW_VAR_in_variables_definition1008); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_VAR.Add(VAR67);

            	// PascalGrammar.g:137:6: ( ident_list type ( SEMICOLON )+ )+
            	int cnt15 = 0;
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == IDENT) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // PascalGrammar.g:137:7: ident_list type ( SEMICOLON )+
            			    {
            			    	PushFollow(FOLLOW_ident_list_in_variables_definition1011);
            			    	ident_list68 = ident_list();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_ident_list.Add(ident_list68.Tree);
            			    	PushFollow(FOLLOW_type_in_variables_definition1013);
            			    	type69 = type();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_type.Add(type69.Tree);
            			    	// PascalGrammar.g:137:23: ( SEMICOLON )+
            			    	int cnt14 = 0;
            			    	do 
            			    	{
            			    	    int alt14 = 2;
            			    	    int LA14_0 = input.LA(1);

            			    	    if ( (LA14_0 == SEMICOLON) )
            			    	    {
            			    	        alt14 = 1;
            			    	    }


            			    	    switch (alt14) 
            			    		{
            			    			case 1 :
            			    			    // PascalGrammar.g:0:0: SEMICOLON
            			    			    {
            			    			    	SEMICOLON70=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_variables_definition1015); if (state.failed) return retval; 
            			    			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON70);


            			    			    }
            			    			    break;

            			    			default:
            			    			    if ( cnt14 >= 1 ) goto loop14;
            			    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		            EarlyExitException eee14 =
            			    		                new EarlyExitException(14, input);
            			    		            throw eee14;
            			    	    }
            			    	    cnt14++;
            			    	} while (true);

            			    	loop14:
            			    		;	// Stops C# compiler whining that label 'loop14' has no statements


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



            	// AST REWRITE
            	// elements:          type, VAR, ident_list
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 137:36: -> ^( VAR ( ^( type ident_list ) )+ )
            	{
            	    // PascalGrammar.g:137:39: ^( VAR ( ^( type ident_list ) )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

            	    if ( !(stream_type.HasNext() || stream_ident_list.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_type.HasNext() || stream_ident_list.HasNext() )
            	    {
            	        // PascalGrammar.g:137:45: ^( type ident_list )
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_2);

            	        adaptor.AddChild(root_2, stream_ident_list.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_type.Reset();
            	    stream_ident_list.Reset();

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
            	Memoize(input, 13, variables_definition_StartIndex); 
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
    // PascalGrammar.g:140:1: params_definition : ( ident_list type ) -> ^( type ident_list ) ;
    public PascalGrammarParser.params_definition_return params_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.params_definition_return retval = new PascalGrammarParser.params_definition_return();
        retval.Start = input.LT(1);
        int params_definition_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.ident_list_return ident_list71 = default(PascalGrammarParser.ident_list_return);

        PascalGrammarParser.type_return type72 = default(PascalGrammarParser.type_return);


        RewriteRuleSubtreeStream stream_ident_list = new RewriteRuleSubtreeStream(adaptor,"rule ident_list");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:141:2: ( ( ident_list type ) -> ^( type ident_list ) )
            // PascalGrammar.g:142:2: ( ident_list type )
            {
            	// PascalGrammar.g:142:2: ( ident_list type )
            	// PascalGrammar.g:142:3: ident_list type
            	{
            		PushFollow(FOLLOW_ident_list_in_params_definition1046);
            		ident_list71 = ident_list();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_ident_list.Add(ident_list71.Tree);
            		PushFollow(FOLLOW_type_in_params_definition1048);
            		type72 = type();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_type.Add(type72.Tree);

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
            	// 142:20: -> ^( type ident_list )
            	{
            	    // PascalGrammar.g:142:23: ^( type ident_list )
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
            	Memoize(input, 14, params_definition_StartIndex); 
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
    // PascalGrammar.g:145:1: method_definition : ( ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) | ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) );
    public PascalGrammarParser.method_definition_return method_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.method_definition_return retval = new PascalGrammarParser.method_definition_return();
        retval.Start = input.LT(1);
        int method_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken PROCEDURE73 = null;
        IToken IDENT74 = null;
        IToken char_literal75 = null;
        IToken char_literal77 = null;
        IToken char_literal79 = null;
        IToken SEMICOLON80 = null;
        IToken BLOCKOPEN83 = null;
        IToken BLOCKEND85 = null;
        IToken FUNCTION86 = null;
        IToken IDENT87 = null;
        IToken char_literal88 = null;
        IToken char_literal90 = null;
        IToken char_literal92 = null;
        IToken SEMICOLON94 = null;
        IToken BLOCKOPEN97 = null;
        IToken BLOCKEND99 = null;
        PascalGrammarParser.params_definition_return params_definition76 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.params_definition_return params_definition78 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.methods_definition_return methods_definition81 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition82 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.expr_list_return expr_list84 = default(PascalGrammarParser.expr_list_return);

        PascalGrammarParser.params_definition_return params_definition89 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.params_definition_return params_definition91 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.type_return type93 = default(PascalGrammarParser.type_return);

        PascalGrammarParser.methods_definition_return methods_definition95 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition96 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.expr_list_return expr_list98 = default(PascalGrammarParser.expr_list_return);


        object PROCEDURE73_tree=null;
        object IDENT74_tree=null;
        object char_literal75_tree=null;
        object char_literal77_tree=null;
        object char_literal79_tree=null;
        object SEMICOLON80_tree=null;
        object BLOCKOPEN83_tree=null;
        object BLOCKEND85_tree=null;
        object FUNCTION86_tree=null;
        object IDENT87_tree=null;
        object char_literal88_tree=null;
        object char_literal90_tree=null;
        object char_literal92_tree=null;
        object SEMICOLON94_tree=null;
        object BLOCKOPEN97_tree=null;
        object BLOCKEND99_tree=null;
        RewriteRuleTokenStream stream_FUNCTION = new RewriteRuleTokenStream(adaptor,"token FUNCTION");
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_PROCEDURE = new RewriteRuleTokenStream(adaptor,"token PROCEDURE");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_methods_definition = new RewriteRuleSubtreeStream(adaptor,"rule methods_definition");
        RewriteRuleSubtreeStream stream_variables_definition = new RewriteRuleSubtreeStream(adaptor,"rule variables_definition");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        RewriteRuleSubtreeStream stream_params_definition = new RewriteRuleSubtreeStream(adaptor,"rule params_definition");
        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:146:2: ( ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) | ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) )
            int alt26 = 2;
            int LA26_0 = input.LA(1);

            if ( (LA26_0 == PROCEDURE) )
            {
                alt26 = 1;
            }
            else if ( (LA26_0 == FUNCTION) )
            {
                alt26 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d26s0 =
                    new NoViableAltException("", 26, 0, input);

                throw nvae_d26s0;
            }
            switch (alt26) 
            {
                case 1 :
                    // PascalGrammar.g:147:2: ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    {
                    	// PascalGrammar.g:147:2: ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    	// PascalGrammar.g:147:3: PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND
                    	{
                    		PROCEDURE73=(IToken)Match(input,PROCEDURE,FOLLOW_PROCEDURE_in_method_definition1072); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_PROCEDURE.Add(PROCEDURE73);

                    		IDENT74=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_method_definition1074); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT74);

                    		// PascalGrammar.g:147:19: ( '(' ( params_definition ( ';' params_definition )* )? ')' )?
                    		int alt18 = 2;
                    		int LA18_0 = input.LA(1);

                    		if ( (LA18_0 == 38) )
                    		{
                    		    alt18 = 1;
                    		}
                    		switch (alt18) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:147:20: '(' ( params_definition ( ';' params_definition )* )? ')'
                    		        {
                    		        	char_literal75=(IToken)Match(input,38,FOLLOW_38_in_method_definition1077); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_38.Add(char_literal75);

                    		        	// PascalGrammar.g:147:24: ( params_definition ( ';' params_definition )* )?
                    		        	int alt17 = 2;
                    		        	int LA17_0 = input.LA(1);

                    		        	if ( (LA17_0 == IDENT) )
                    		        	{
                    		        	    alt17 = 1;
                    		        	}
                    		        	switch (alt17) 
                    		        	{
                    		        	    case 1 :
                    		        	        // PascalGrammar.g:147:25: params_definition ( ';' params_definition )*
                    		        	        {
                    		        	        	PushFollow(FOLLOW_params_definition_in_method_definition1080);
                    		        	        	params_definition76 = params_definition();
                    		        	        	state.followingStackPointer--;
                    		        	        	if (state.failed) return retval;
                    		        	        	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition76.Tree);
                    		        	        	// PascalGrammar.g:147:43: ( ';' params_definition )*
                    		        	        	do 
                    		        	        	{
                    		        	        	    int alt16 = 2;
                    		        	        	    int LA16_0 = input.LA(1);

                    		        	        	    if ( (LA16_0 == SEMICOLON) )
                    		        	        	    {
                    		        	        	        alt16 = 1;
                    		        	        	    }


                    		        	        	    switch (alt16) 
                    		        	        		{
                    		        	        			case 1 :
                    		        	        			    // PascalGrammar.g:147:44: ';' params_definition
                    		        	        			    {
                    		        	        			    	char_literal77=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1083); if (state.failed) return retval; 
                    		        	        			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(char_literal77);

                    		        	        			    	PushFollow(FOLLOW_params_definition_in_method_definition1085);
                    		        	        			    	params_definition78 = params_definition();
                    		        	        			    	state.followingStackPointer--;
                    		        	        			    	if (state.failed) return retval;
                    		        	        			    	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition78.Tree);

                    		        	        			    }
                    		        	        			    break;

                    		        	        			default:
                    		        	        			    goto loop16;
                    		        	        	    }
                    		        	        	} while (true);

                    		        	        	loop16:
                    		        	        		;	// Stops C# compiler whining that label 'loop16' has no statements


                    		        	        }
                    		        	        break;

                    		        	}

                    		        	char_literal79=(IToken)Match(input,39,FOLLOW_39_in_method_definition1091); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_39.Add(char_literal79);


                    		        }
                    		        break;

                    		}

                    		SEMICOLON80=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1095); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON80);

                    		// PascalGrammar.g:147:86: ( methods_definition )?
                    		int alt19 = 2;
                    		int LA19_0 = input.LA(1);

                    		if ( ((LA19_0 >= FUNCTION && LA19_0 <= PROCEDURE)) )
                    		{
                    		    alt19 = 1;
                    		}
                    		switch (alt19) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:0:0: methods_definition
                    		        {
                    		        	PushFollow(FOLLOW_methods_definition_in_method_definition1097);
                    		        	methods_definition81 = methods_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition81.Tree);

                    		        }
                    		        break;

                    		}

                    		// PascalGrammar.g:148:2: ( variables_definition )?
                    		int alt20 = 2;
                    		int LA20_0 = input.LA(1);

                    		if ( (LA20_0 == VAR) )
                    		{
                    		    alt20 = 1;
                    		}
                    		switch (alt20) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:0:0: variables_definition
                    		        {
                    		        	PushFollow(FOLLOW_variables_definition_in_method_definition1102);
                    		        	variables_definition82 = variables_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition82.Tree);

                    		        }
                    		        break;

                    		}

                    		BLOCKOPEN83=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_method_definition1105); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN83);

                    		PushFollow(FOLLOW_expr_list_in_method_definition1107);
                    		expr_list84 = expr_list();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list84.Tree);
                    		BLOCKEND85=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_method_definition1109); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND85);


                    	}



                    	// AST REWRITE
                    	// elements:          variables_definition, expr_list, PROCEDURE, methods_definition, params_definition
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 149:2: -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	{
                    	    // PascalGrammar.g:149:5: ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new ProcedureAstNode(PROCEDURE, ((IDENT74 != null) ? IDENT74.Text : null)), root_1);

                    	    // PascalGrammar.g:149:48: ( ^( PARAMS ( params_definition )* ) )?
                    	    if ( stream_params_definition.HasNext() )
                    	    {
                    	        // PascalGrammar.g:149:48: ^( PARAMS ( params_definition )* )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

                    	        // PascalGrammar.g:149:57: ( params_definition )*
                    	        while ( stream_params_definition.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_2, stream_params_definition.NextTree());

                    	        }
                    	        stream_params_definition.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_params_definition.Reset();
                    	    // PascalGrammar.g:149:78: ( methods_definition )?
                    	    if ( stream_methods_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

                    	    }
                    	    stream_methods_definition.Reset();
                    	    // PascalGrammar.g:149:98: ( variables_definition )?
                    	    if ( stream_variables_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

                    	    }
                    	    stream_variables_definition.Reset();
                    	    // PascalGrammar.g:149:120: ^( BLOCK expr_list )
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
                    // PascalGrammar.g:151:2: ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    {
                    	// PascalGrammar.g:151:2: ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    	// PascalGrammar.g:151:3: FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND
                    	{
                    		FUNCTION86=(IToken)Match(input,FUNCTION,FOLLOW_FUNCTION_in_method_definition1149); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_FUNCTION.Add(FUNCTION86);

                    		IDENT87=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_method_definition1151); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT87);

                    		// PascalGrammar.g:151:18: ( '(' ( params_definition ( ';' params_definition )* )? ')' )?
                    		int alt23 = 2;
                    		int LA23_0 = input.LA(1);

                    		if ( (LA23_0 == 38) )
                    		{
                    		    alt23 = 1;
                    		}
                    		switch (alt23) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:151:19: '(' ( params_definition ( ';' params_definition )* )? ')'
                    		        {
                    		        	char_literal88=(IToken)Match(input,38,FOLLOW_38_in_method_definition1154); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_38.Add(char_literal88);

                    		        	// PascalGrammar.g:151:23: ( params_definition ( ';' params_definition )* )?
                    		        	int alt22 = 2;
                    		        	int LA22_0 = input.LA(1);

                    		        	if ( (LA22_0 == IDENT) )
                    		        	{
                    		        	    alt22 = 1;
                    		        	}
                    		        	switch (alt22) 
                    		        	{
                    		        	    case 1 :
                    		        	        // PascalGrammar.g:151:24: params_definition ( ';' params_definition )*
                    		        	        {
                    		        	        	PushFollow(FOLLOW_params_definition_in_method_definition1157);
                    		        	        	params_definition89 = params_definition();
                    		        	        	state.followingStackPointer--;
                    		        	        	if (state.failed) return retval;
                    		        	        	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition89.Tree);
                    		        	        	// PascalGrammar.g:151:42: ( ';' params_definition )*
                    		        	        	do 
                    		        	        	{
                    		        	        	    int alt21 = 2;
                    		        	        	    int LA21_0 = input.LA(1);

                    		        	        	    if ( (LA21_0 == SEMICOLON) )
                    		        	        	    {
                    		        	        	        alt21 = 1;
                    		        	        	    }


                    		        	        	    switch (alt21) 
                    		        	        		{
                    		        	        			case 1 :
                    		        	        			    // PascalGrammar.g:151:43: ';' params_definition
                    		        	        			    {
                    		        	        			    	char_literal90=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1160); if (state.failed) return retval; 
                    		        	        			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(char_literal90);

                    		        	        			    	PushFollow(FOLLOW_params_definition_in_method_definition1162);
                    		        	        			    	params_definition91 = params_definition();
                    		        	        			    	state.followingStackPointer--;
                    		        	        			    	if (state.failed) return retval;
                    		        	        			    	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition91.Tree);

                    		        	        			    }
                    		        	        			    break;

                    		        	        			default:
                    		        	        			    goto loop21;
                    		        	        	    }
                    		        	        	} while (true);

                    		        	        	loop21:
                    		        	        		;	// Stops C# compiler whining that label 'loop21' has no statements


                    		        	        }
                    		        	        break;

                    		        	}

                    		        	char_literal92=(IToken)Match(input,39,FOLLOW_39_in_method_definition1168); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_39.Add(char_literal92);


                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_type_in_method_definition1172);
                    		type93 = type();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_type.Add(type93.Tree);
                    		SEMICOLON94=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1174); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON94);

                    		// PascalGrammar.g:151:90: ( methods_definition )?
                    		int alt24 = 2;
                    		int LA24_0 = input.LA(1);

                    		if ( ((LA24_0 >= FUNCTION && LA24_0 <= PROCEDURE)) )
                    		{
                    		    alt24 = 1;
                    		}
                    		switch (alt24) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:0:0: methods_definition
                    		        {
                    		        	PushFollow(FOLLOW_methods_definition_in_method_definition1176);
                    		        	methods_definition95 = methods_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition95.Tree);

                    		        }
                    		        break;

                    		}

                    		// PascalGrammar.g:152:2: ( variables_definition )?
                    		int alt25 = 2;
                    		int LA25_0 = input.LA(1);

                    		if ( (LA25_0 == VAR) )
                    		{
                    		    alt25 = 1;
                    		}
                    		switch (alt25) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:0:0: variables_definition
                    		        {
                    		        	PushFollow(FOLLOW_variables_definition_in_method_definition1181);
                    		        	variables_definition96 = variables_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition96.Tree);

                    		        }
                    		        break;

                    		}

                    		BLOCKOPEN97=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_method_definition1184); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN97);

                    		PushFollow(FOLLOW_expr_list_in_method_definition1186);
                    		expr_list98 = expr_list();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list98.Tree);
                    		BLOCKEND99=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_method_definition1188); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND99);


                    	}



                    	// AST REWRITE
                    	// elements:          variables_definition, expr_list, methods_definition, type, params_definition, FUNCTION
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 153:2: -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	{
                    	    // PascalGrammar.g:153:5: ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new FunctionAstNode(FUNCTION, ((IDENT87 != null) ? IDENT87.Text : null), ""), root_1);

                    	    adaptor.AddChild(root_1, stream_type.NextTree());
                    	    // PascalGrammar.g:153:55: ( ^( PARAMS ( params_definition )* ) )?
                    	    if ( stream_params_definition.HasNext() )
                    	    {
                    	        // PascalGrammar.g:153:55: ^( PARAMS ( params_definition )* )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

                    	        // PascalGrammar.g:153:64: ( params_definition )*
                    	        while ( stream_params_definition.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_2, stream_params_definition.NextTree());

                    	        }
                    	        stream_params_definition.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_params_definition.Reset();
                    	    // PascalGrammar.g:153:85: ( methods_definition )?
                    	    if ( stream_methods_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

                    	    }
                    	    stream_methods_definition.Reset();
                    	    // PascalGrammar.g:153:105: ( variables_definition )?
                    	    if ( stream_variables_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

                    	    }
                    	    stream_variables_definition.Reset();
                    	    // PascalGrammar.g:153:127: ^( BLOCK expr_list )
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
            	Memoize(input, 15, method_definition_StartIndex); 
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
    // PascalGrammar.g:156:1: methods_definition : method_definition ( SEMICOLON method_definition )* ( SEMICOLON )* -> ^( METHODS ( method_definition )* ) ;
    public PascalGrammarParser.methods_definition_return methods_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.methods_definition_return retval = new PascalGrammarParser.methods_definition_return();
        retval.Start = input.LT(1);
        int methods_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken SEMICOLON101 = null;
        IToken SEMICOLON103 = null;
        PascalGrammarParser.method_definition_return method_definition100 = default(PascalGrammarParser.method_definition_return);

        PascalGrammarParser.method_definition_return method_definition102 = default(PascalGrammarParser.method_definition_return);


        object SEMICOLON101_tree=null;
        object SEMICOLON103_tree=null;
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleSubtreeStream stream_method_definition = new RewriteRuleSubtreeStream(adaptor,"rule method_definition");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:157:2: ( method_definition ( SEMICOLON method_definition )* ( SEMICOLON )* -> ^( METHODS ( method_definition )* ) )
            // PascalGrammar.g:158:2: method_definition ( SEMICOLON method_definition )* ( SEMICOLON )*
            {
            	PushFollow(FOLLOW_method_definition_in_methods_definition1237);
            	method_definition100 = method_definition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_method_definition.Add(method_definition100.Tree);
            	// PascalGrammar.g:158:20: ( SEMICOLON method_definition )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( (LA27_0 == SEMICOLON) )
            	    {
            	        int LA27_1 = input.LA(2);

            	        if ( ((LA27_1 >= FUNCTION && LA27_1 <= PROCEDURE)) )
            	        {
            	            alt27 = 1;
            	        }


            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // PascalGrammar.g:158:21: SEMICOLON method_definition
            			    {
            			    	SEMICOLON101=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_methods_definition1240); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON101);

            			    	PushFollow(FOLLOW_method_definition_in_methods_definition1242);
            			    	method_definition102 = method_definition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_method_definition.Add(method_definition102.Tree);

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements

            	// PascalGrammar.g:158:51: ( SEMICOLON )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( (LA28_0 == SEMICOLON) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // PascalGrammar.g:0:0: SEMICOLON
            			    {
            			    	SEMICOLON103=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_methods_definition1246); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON103);


            			    }
            			    break;

            			default:
            			    goto loop28;
            	    }
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements



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
            	// 158:62: -> ^( METHODS ( method_definition )* )
            	{
            	    // PascalGrammar.g:158:65: ^( METHODS ( method_definition )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METHODS, "METHODS"), root_1);

            	    // PascalGrammar.g:158:75: ( method_definition )*
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
            	Memoize(input, 16, methods_definition_StartIndex); 
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
    // PascalGrammar.g:161:1: program : PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.' -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body ) ;
    public PascalGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        PascalGrammarParser.program_return retval = new PascalGrammarParser.program_return();
        retval.Start = input.LT(1);
        int program_StartIndex = input.Index();
        object root_0 = null;

        IToken PROGRAM104 = null;
        IToken IDENT105 = null;
        IToken SEMICOLON106 = null;
        IToken BLOCKOPEN109 = null;
        IToken BLOCKEND111 = null;
        IToken char_literal112 = null;
        PascalGrammarParser.methods_definition_return methods_definition107 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition108 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.program_body_return program_body110 = default(PascalGrammarParser.program_body_return);


        object PROGRAM104_tree=null;
        object IDENT105_tree=null;
        object SEMICOLON106_tree=null;
        object BLOCKOPEN109_tree=null;
        object BLOCKEND111_tree=null;
        object char_literal112_tree=null;
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_PROGRAM = new RewriteRuleTokenStream(adaptor,"token PROGRAM");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleSubtreeStream stream_methods_definition = new RewriteRuleSubtreeStream(adaptor,"rule methods_definition");
        RewriteRuleSubtreeStream stream_program_body = new RewriteRuleSubtreeStream(adaptor,"rule program_body");
        RewriteRuleSubtreeStream stream_variables_definition = new RewriteRuleSubtreeStream(adaptor,"rule variables_definition");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:162:2: ( PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.' -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body ) )
            // PascalGrammar.g:163:2: PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.'
            {
            	PROGRAM104=(IToken)Match(input,PROGRAM,FOLLOW_PROGRAM_in_program1273); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PROGRAM.Add(PROGRAM104);

            	IDENT105=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_program1275); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT105);

            	SEMICOLON106=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_program1277); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON106);

            	// PascalGrammar.g:163:26: ( methods_definition )?
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( ((LA29_0 >= FUNCTION && LA29_0 <= PROCEDURE)) )
            	{
            	    alt29 = 1;
            	}
            	switch (alt29) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:0:0: methods_definition
            	        {
            	        	PushFollow(FOLLOW_methods_definition_in_program1279);
            	        	methods_definition107 = methods_definition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition107.Tree);

            	        }
            	        break;

            	}

            	// PascalGrammar.g:163:46: ( variables_definition )?
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( (LA30_0 == VAR) )
            	{
            	    alt30 = 1;
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:0:0: variables_definition
            	        {
            	        	PushFollow(FOLLOW_variables_definition_in_program1282);
            	        	variables_definition108 = variables_definition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition108.Tree);

            	        }
            	        break;

            	}

            	BLOCKOPEN109=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_program1286); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN109);

            	PushFollow(FOLLOW_program_body_in_program1288);
            	program_body110 = program_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_program_body.Add(program_body110.Tree);
            	BLOCKEND111=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_program1290); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND111);

            	char_literal112=(IToken)Match(input,42,FOLLOW_42_in_program1292); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal112);



            	// AST REWRITE
            	// elements:          methods_definition, program_body, variables_definition, PROGRAM
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 164:3: -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body )
            	{
            	    // PascalGrammar.g:164:6: ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ProgAstNode(PROGRAM, ((IDENT105 != null) ? IDENT105.Text : null)), root_1);

            	    // PascalGrammar.g:164:42: ( methods_definition )?
            	    if ( stream_methods_definition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

            	    }
            	    stream_methods_definition.Reset();
            	    // PascalGrammar.g:164:62: ( variables_definition )?
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
            	Memoize(input, 17, program_StartIndex); 
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
    // PascalGrammar.g:167:1: result : program ;
    public PascalGrammarParser.result_return result() // throws RecognitionException [1]
    {   
        PascalGrammarParser.result_return retval = new PascalGrammarParser.result_return();
        retval.Start = input.LT(1);
        int result_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.program_return program113 = default(PascalGrammarParser.program_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:168:2: ( program )
            // PascalGrammar.g:169:2: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_result1330);
            	program113 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program113.Tree);

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
            	Memoize(input, 18, result_StartIndex); 
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
    // PascalGrammar.g:172:1: execute : result ;
    public PascalGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        PascalGrammarParser.execute_return retval = new PascalGrammarParser.execute_return();
        retval.Start = input.LT(1);
        int execute_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.result_return result114 = default(PascalGrammarParser.result_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:173:2: ( result )
            // PascalGrammar.g:174:2: result
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_result_in_execute1348);
            	result114 = result();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result114.Tree);

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
            	Memoize(input, 19, execute_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "execute"

    // $ANTLR start "synpred20_PascalGrammar"
    public void synpred20_PascalGrammar_fragment() {
        // PascalGrammar.g:110:28: ( ELSE expr )
        // PascalGrammar.g:110:28: ELSE expr
        {
        	Match(input,ELSE,FOLLOW_ELSE_in_synpred20_PascalGrammar834); if (state.failed) return ;
        	PushFollow(FOLLOW_expr_in_synpred20_PascalGrammar837);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred20_PascalGrammar"

    // Delegated rules

   	public bool synpred20_PascalGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred20_PascalGrammar_fragment(); // can never throw exception
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


   	protected DFA8 dfa8;
   	protected DFA11 dfa11;
	private void InitializeCyclicDFAs()
	{
    	this.dfa8 = new DFA8(this);
    	this.dfa11 = new DFA11(this);
	}

    const string DFA8_eotS =
        "\x0a\uffff";
    const string DFA8_eofS =
        "\x01\uffff\x01\x09\x08\uffff";
    const string DFA8_minS =
        "\x01\x0b\x01\x0a\x08\uffff";
    const string DFA8_maxS =
        "\x01\x1b\x01\x26\x08\uffff";
    const string DFA8_acceptS =
        "\x02\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x02\x01"+
        "\x03\x01\x01";
    const string DFA8_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x02\x04\uffff\x01\x03\x02\uffff\x01\x04\x01\uffff\x01"+
            "\x06\x01\x05\x04\uffff\x01\x01",
            "\x01\x09\x01\uffff\x01\x09\x05\uffff\x01\x09\x03\uffff\x01"+
            "\x09\x0d\uffff\x01\x07\x01\uffff\x01\x08",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "105:1: expr : ( IDENT | IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare );"; }
        }

    }

    const string DFA11_eotS =
        "\x04\uffff";
    const string DFA11_eofS =
        "\x04\uffff";
    const string DFA11_minS =
        "\x02\x0a\x02\uffff";
    const string DFA11_maxS =
        "\x01\x0c\x01\x1b\x02\uffff";
    const string DFA11_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA11_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x01\x01\uffff\x01\x02",
            "\x01\x01\x01\x03\x01\x02\x03\uffff\x01\x03\x02\uffff\x01\x03"+
            "\x01\uffff\x02\x03\x04\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 118:15: ( ( ';' )+ expr )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_38_in_group575 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_term_in_group578 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_group580 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_group586 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOLEAN_in_group599 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_group604 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_group609 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_group614 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult637 = new BitSet(new ulong[]{0x0000000C00800002UL});
    public static readonly BitSet FOLLOW_set_in_mult641 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_group_in_mult656 = new BitSet(new ulong[]{0x0000000C00800002UL});
    public static readonly BitSet FOLLOW_mult_in_add668 = new BitSet(new ulong[]{0x0000000303000002UL});
    public static readonly BitSet FOLLOW_set_in_add673 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_mult_in_add692 = new BitSet(new ulong[]{0x0000000303000002UL});
    public static readonly BitSet FOLLOW_add_in_compare705 = new BitSet(new ulong[]{0x0000002000000002UL});
    public static readonly BitSet FOLLOW_COMPARE_in_compare709 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_add_in_compare712 = new BitSet(new ulong[]{0x0000002000000002UL});
    public static readonly BitSet FOLLOW_compare_in_term721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_arg_list730 = new BitSet(new ulong[]{0x0000010000000002UL});
    public static readonly BitSet FOLLOW_40_in_arg_list733 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_term_in_arg_list736 = new BitSet(new ulong[]{0x0000010000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_func_call752 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_func_call755 = new BitSet(new ulong[]{0x000000C05C000000UL});
    public static readonly BitSet FOLLOW_arg_list_in_func_call757 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_func_call759 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr787 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr791 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr793 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_term_in_expr796 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_expr801 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_expr806 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_expr808 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_expr810 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_expr823 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr826 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_THEN_in_expr828 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr831 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_ELSE_in_expr834 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr844 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr847 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr849 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_add_in_expr852 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_TO_in_expr854 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_add_in_expr857 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_DO_in_expr859 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr862 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr867 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr870 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_DO_in_expr872 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr875 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DO_in_expr880 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr883 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr885 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list906 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr_list911 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list916 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr_list921 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list927 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_expr_list_in_program_body944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident_list966 = new BitSet(new ulong[]{0x0000010000000002UL});
    public static readonly BitSet FOLLOW_40_in_ident_list969 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident_list972 = new BitSet(new ulong[]{0x0000010000000002UL});
    public static readonly BitSet FOLLOW_41_in_type987 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_type989 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_in_variables_definition1008 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_ident_list_in_variables_definition1011 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_type_in_variables_definition1013 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_variables_definition1015 = new BitSet(new ulong[]{0x0000000008000402UL});
    public static readonly BitSet FOLLOW_ident_list_in_params_definition1046 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_type_in_params_definition1048 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PROCEDURE_in_method_definition1072 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_method_definition1074 = new BitSet(new ulong[]{0x0000004000000400UL});
    public static readonly BitSet FOLLOW_38_in_method_definition1077 = new BitSet(new ulong[]{0x0000008008000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1080 = new BitSet(new ulong[]{0x0000008000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1083 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1085 = new BitSet(new ulong[]{0x0000008000000400UL});
    public static readonly BitSet FOLLOW_39_in_method_definition1091 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1095 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_method_definition1097 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_method_definition1102 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_method_definition1105 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_method_definition1107 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_method_definition1109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNCTION_in_method_definition1149 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_method_definition1151 = new BitSet(new ulong[]{0x0000024000000000UL});
    public static readonly BitSet FOLLOW_38_in_method_definition1154 = new BitSet(new ulong[]{0x0000008008000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1157 = new BitSet(new ulong[]{0x0000008000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1160 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1162 = new BitSet(new ulong[]{0x0000008000000400UL});
    public static readonly BitSet FOLLOW_39_in_method_definition1168 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_type_in_method_definition1172 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1174 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_method_definition1176 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_method_definition1181 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_method_definition1184 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_method_definition1186 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_method_definition1188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_method_definition_in_methods_definition1237 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_methods_definition1240 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_method_definition_in_methods_definition1242 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_methods_definition1246 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_PROGRAM_in_program1273 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_program1275 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_program1277 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_program1279 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_program1282 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_program1286 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_program_body_in_program1288 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_program1290 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_program1292 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_result1330 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_result_in_execute1348 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_synpred20_PascalGrammar834 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_synpred20_PascalGrammar837 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}