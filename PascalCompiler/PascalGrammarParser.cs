// $ANTLR 3.2 Sep 23, 2009 12:02:23 PascalGrammar.g 2013-10-27 19:40:44

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
            this.state.ruleMemo = new Hashtable[63+1];
             
             
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

                if ( (LA1_4 == 38) )
                {
                    alt1 = 4;
                }
                else if ( (LA1_4 == EOF || LA1_4 == SEMICOLON || LA1_4 == BLOCKEND || (LA1_4 >= THEN && LA1_4 <= ELSE) || (LA1_4 >= TO && LA1_4 <= XOR) || (LA1_4 >= ADD && LA1_4 <= DIV) || LA1_4 == COMPARE || (LA1_4 >= 39 && LA1_4 <= 40)) )
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
    // PascalGrammar.g:105:1: expr : ( IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare );
    public PascalGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        PascalGrammarParser.expr_return retval = new PascalGrammarParser.expr_return();
        retval.Start = input.LT(1);
        int expr_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT26 = null;
        IToken ASSIGN27 = null;
        IToken BLOCKOPEN30 = null;
        IToken BLOCKEND32 = null;
        IToken IF33 = null;
        IToken THEN35 = null;
        IToken ELSE37 = null;
        IToken FOR39 = null;
        IToken IDENT40 = null;
        IToken ASSIGN41 = null;
        IToken TO43 = null;
        IToken DO45 = null;
        IToken WHILE47 = null;
        IToken DO49 = null;
        IToken DO51 = null;
        IToken WHILE53 = null;
        PascalGrammarParser.term_return term28 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.func_call_return func_call29 = default(PascalGrammarParser.func_call_return);

        PascalGrammarParser.expr_list_return expr_list31 = default(PascalGrammarParser.expr_list_return);

        PascalGrammarParser.compare_return compare34 = default(PascalGrammarParser.compare_return);

        PascalGrammarParser.expr_return expr36 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr38 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.add_return add42 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.add_return add44 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.expr_return expr46 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.compare_return compare48 = default(PascalGrammarParser.compare_return);

        PascalGrammarParser.expr_return expr50 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr52 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.compare_return compare54 = default(PascalGrammarParser.compare_return);


        object IDENT26_tree=null;
        object ASSIGN27_tree=null;
        object BLOCKOPEN30_tree=null;
        object BLOCKEND32_tree=null;
        object IF33_tree=null;
        object THEN35_tree=null;
        object ELSE37_tree=null;
        object FOR39_tree=null;
        object IDENT40_tree=null;
        object ASSIGN41_tree=null;
        object TO43_tree=null;
        object DO45_tree=null;
        object WHILE47_tree=null;
        object DO49_tree=null;
        object DO51_tree=null;
        object WHILE53_tree=null;
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:105:6: ( IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare )
            int alt8 = 7;
            switch ( input.LA(1) ) 
            {
            case IDENT:
            	{
                int LA8_1 = input.LA(2);

                if ( (LA8_1 == ASSIGN) )
                {
                    alt8 = 1;
                }
                else if ( (LA8_1 == 38) )
                {
                    alt8 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d8s1 =
                        new NoViableAltException("", 8, 1, input);

                    throw nvae_d8s1;
                }
                }
                break;
            case BLOCKOPEN:
            	{
                alt8 = 3;
                }
                break;
            case IF:
            	{
                alt8 = 4;
                }
                break;
            case FOR:
            	{
                alt8 = 5;
                }
                break;
            case WHILE:
            	{
                alt8 = 6;
                }
                break;
            case DO:
            	{
                alt8 = 7;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            }

            switch (alt8) 
            {
                case 1 :
                    // PascalGrammar.g:106:2: IDENT ASSIGN term
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT26=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr787); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT26_tree = (object)adaptor.Create(IDENT26);
                    		adaptor.AddChild(root_0, IDENT26_tree);
                    	}
                    	ASSIGN27=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr789); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN27_tree = (object)adaptor.Create(ASSIGN27);
                    		root_0 = (object)adaptor.BecomeRoot(ASSIGN27_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr792);
                    	term28 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term28.Tree);

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:107:4: func_call
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_expr797);
                    	func_call29 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call29.Tree);

                    }
                    break;
                case 3 :
                    // PascalGrammar.g:108:4: BLOCKOPEN expr_list BLOCKEND
                    {
                    	BLOCKOPEN30=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_expr802); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN30);

                    	PushFollow(FOLLOW_expr_list_in_expr804);
                    	expr_list31 = expr_list();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list31.Tree);
                    	BLOCKEND32=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_expr806); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND32);



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
                    	// 108:33: -> ^( BLOCK expr_list )
                    	{
                    	    // PascalGrammar.g:108:36: ^( BLOCK expr_list )
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
                case 4 :
                    // PascalGrammar.g:109:4: IF compare THEN expr ( ELSE expr )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IF33=(IToken)Match(input,IF,FOLLOW_IF_in_expr819); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IF33_tree = (object)adaptor.Create(IF33);
                    		root_0 = (object)adaptor.BecomeRoot(IF33_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_compare_in_expr822);
                    	compare34 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare34.Tree);
                    	THEN35=(IToken)Match(input,THEN,FOLLOW_THEN_in_expr824); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr827);
                    	expr36 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr36.Tree);
                    	// PascalGrammar.g:109:27: ( ELSE expr )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == ELSE) )
                    	{
                    	    int LA7_1 = input.LA(2);

                    	    if ( (synpred19_PascalGrammar()) )
                    	    {
                    	        alt7 = 1;
                    	    }
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // PascalGrammar.g:109:28: ELSE expr
                    	        {
                    	        	ELSE37=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_expr830); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_expr_in_expr833);
                    	        	expr38 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr38.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 5 :
                    // PascalGrammar.g:110:4: FOR IDENT ASSIGN add TO add DO expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FOR39=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr840); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FOR39_tree = (object)adaptor.Create(FOR39);
                    		root_0 = (object)adaptor.BecomeRoot(FOR39_tree, root_0);
                    	}
                    	IDENT40=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr843); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT40_tree = (object)adaptor.Create(IDENT40);
                    		adaptor.AddChild(root_0, IDENT40_tree);
                    	}
                    	ASSIGN41=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr845); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_expr848);
                    	add42 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add42.Tree);
                    	TO43=(IToken)Match(input,TO,FOLLOW_TO_in_expr850); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_expr853);
                    	add44 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add44.Tree);
                    	DO45=(IToken)Match(input,DO,FOLLOW_DO_in_expr855); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr858);
                    	expr46 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr46.Tree);

                    }
                    break;
                case 6 :
                    // PascalGrammar.g:111:4: WHILE compare DO expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	WHILE47=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr863); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WHILE47_tree = (object)adaptor.Create(WHILE47);
                    		root_0 = (object)adaptor.BecomeRoot(WHILE47_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_compare_in_expr866);
                    	compare48 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare48.Tree);
                    	DO49=(IToken)Match(input,DO,FOLLOW_DO_in_expr868); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr871);
                    	expr50 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr50.Tree);

                    }
                    break;
                case 7 :
                    // PascalGrammar.g:112:4: DO expr WHILE compare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	DO51=(IToken)Match(input,DO,FOLLOW_DO_in_expr876); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DO51_tree = (object)adaptor.Create(DO51);
                    		root_0 = (object)adaptor.BecomeRoot(DO51_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_expr_in_expr879);
                    	expr52 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr52.Tree);
                    	WHILE53=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr881); if (state.failed) return retval;
                    	PushFollow(FOLLOW_compare_in_expr884);
                    	compare54 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare54.Tree);

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
    // PascalGrammar.g:115:1: expr_list : ( ';' )* expr ( ( ';' )+ expr )* ( ';' )* ;
    public PascalGrammarParser.expr_list_return expr_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.expr_list_return retval = new PascalGrammarParser.expr_list_return();
        retval.Start = input.LT(1);
        int expr_list_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal55 = null;
        IToken char_literal57 = null;
        IToken char_literal59 = null;
        PascalGrammarParser.expr_return expr56 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr58 = default(PascalGrammarParser.expr_return);


        object char_literal55_tree=null;
        object char_literal57_tree=null;
        object char_literal59_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:116:2: ( ( ';' )* expr ( ( ';' )+ expr )* ( ';' )* )
            // PascalGrammar.g:117:2: ( ';' )* expr ( ( ';' )+ expr )* ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// PascalGrammar.g:117:2: ( ';' )*
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
            			    // PascalGrammar.g:117:3: ';'
            			    {
            			    	char_literal55=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list902); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	PushFollow(FOLLOW_expr_in_expr_list907);
            	expr56 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr56.Tree);
            	// PascalGrammar.g:117:15: ( ( ';' )+ expr )*
            	do 
            	{
            	    int alt11 = 2;
            	    alt11 = dfa11.Predict(input);
            	    switch (alt11) 
            		{
            			case 1 :
            			    // PascalGrammar.g:117:17: ( ';' )+ expr
            			    {
            			    	// PascalGrammar.g:117:17: ( ';' )+
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
            			    			    // PascalGrammar.g:117:18: ';'
            			    			    {
            			    			    	char_literal57=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list912); if (state.failed) return retval;

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

            			    	PushFollow(FOLLOW_expr_in_expr_list917);
            			    	expr58 = expr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr58.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	// PascalGrammar.g:117:33: ( ';' )*
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
            			    // PascalGrammar.g:117:34: ';'
            			    {
            			    	char_literal59=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list923); if (state.failed) return retval;

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
    // PascalGrammar.g:120:1: program_body : expr_list -> ^( BLOCK expr_list ) ;
    public PascalGrammarParser.program_body_return program_body() // throws RecognitionException [1]
    {   
        PascalGrammarParser.program_body_return retval = new PascalGrammarParser.program_body_return();
        retval.Start = input.LT(1);
        int program_body_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.expr_list_return expr_list60 = default(PascalGrammarParser.expr_list_return);


        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:121:2: ( expr_list -> ^( BLOCK expr_list ) )
            // PascalGrammar.g:122:2: expr_list
            {
            	PushFollow(FOLLOW_expr_list_in_program_body940);
            	expr_list60 = expr_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list60.Tree);


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
            	// 122:12: -> ^( BLOCK expr_list )
            	{
            	    // PascalGrammar.g:122:15: ^( BLOCK expr_list )
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
    // PascalGrammar.g:125:1: ident_list : IDENT ( ',' IDENT )* ;
    public PascalGrammarParser.ident_list_return ident_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.ident_list_return retval = new PascalGrammarParser.ident_list_return();
        retval.Start = input.LT(1);
        int ident_list_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT61 = null;
        IToken char_literal62 = null;
        IToken IDENT63 = null;

        object IDENT61_tree=null;
        object char_literal62_tree=null;
        object IDENT63_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:126:2: ( IDENT ( ',' IDENT )* )
            // PascalGrammar.g:127:2: IDENT ( ',' IDENT )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IDENT61=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident_list962); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IDENT61_tree = (object)adaptor.Create(IDENT61);
            		adaptor.AddChild(root_0, IDENT61_tree);
            	}
            	// PascalGrammar.g:127:8: ( ',' IDENT )*
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
            			    // PascalGrammar.g:127:9: ',' IDENT
            			    {
            			    	char_literal62=(IToken)Match(input,40,FOLLOW_40_in_ident_list965); if (state.failed) return retval;
            			    	IDENT63=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident_list968); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{IDENT63_tree = (object)adaptor.Create(IDENT63);
            			    		adaptor.AddChild(root_0, IDENT63_tree);
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
    // PascalGrammar.g:130:1: type : ':' IDENT -> ^( IDENT ) ;
    public PascalGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        PascalGrammarParser.type_return retval = new PascalGrammarParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal64 = null;
        IToken IDENT65 = null;

        object char_literal64_tree=null;
        object IDENT65_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:130:6: ( ':' IDENT -> ^( IDENT ) )
            // PascalGrammar.g:131:2: ':' IDENT
            {
            	char_literal64=(IToken)Match(input,41,FOLLOW_41_in_type983); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal64);

            	IDENT65=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_type985); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT65);



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
            	// 131:12: -> ^( IDENT )
            	{
            	    // PascalGrammar.g:131:15: ^( IDENT )
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
    // PascalGrammar.g:134:1: variables_definition : VAR ( ident_list type ( SEMICOLON )+ )+ -> ^( VAR ( ^( type ident_list ) )+ ) ;
    public PascalGrammarParser.variables_definition_return variables_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.variables_definition_return retval = new PascalGrammarParser.variables_definition_return();
        retval.Start = input.LT(1);
        int variables_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken VAR66 = null;
        IToken SEMICOLON69 = null;
        PascalGrammarParser.ident_list_return ident_list67 = default(PascalGrammarParser.ident_list_return);

        PascalGrammarParser.type_return type68 = default(PascalGrammarParser.type_return);


        object VAR66_tree=null;
        object SEMICOLON69_tree=null;
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
            // PascalGrammar.g:135:2: ( VAR ( ident_list type ( SEMICOLON )+ )+ -> ^( VAR ( ^( type ident_list ) )+ ) )
            // PascalGrammar.g:136:2: VAR ( ident_list type ( SEMICOLON )+ )+
            {
            	VAR66=(IToken)Match(input,VAR,FOLLOW_VAR_in_variables_definition1004); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_VAR.Add(VAR66);

            	// PascalGrammar.g:136:6: ( ident_list type ( SEMICOLON )+ )+
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
            			    // PascalGrammar.g:136:7: ident_list type ( SEMICOLON )+
            			    {
            			    	PushFollow(FOLLOW_ident_list_in_variables_definition1007);
            			    	ident_list67 = ident_list();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_ident_list.Add(ident_list67.Tree);
            			    	PushFollow(FOLLOW_type_in_variables_definition1009);
            			    	type68 = type();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_type.Add(type68.Tree);
            			    	// PascalGrammar.g:136:23: ( SEMICOLON )+
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
            			    			    	SEMICOLON69=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_variables_definition1011); if (state.failed) return retval; 
            			    			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON69);


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
            	// 136:36: -> ^( VAR ( ^( type ident_list ) )+ )
            	{
            	    // PascalGrammar.g:136:39: ^( VAR ( ^( type ident_list ) )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

            	    if ( !(stream_ident_list.HasNext() || stream_type.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_ident_list.HasNext() || stream_type.HasNext() )
            	    {
            	        // PascalGrammar.g:136:45: ^( type ident_list )
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
    // PascalGrammar.g:139:1: params_definition : ( ident_list type ) -> ^( type ident_list ) ;
    public PascalGrammarParser.params_definition_return params_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.params_definition_return retval = new PascalGrammarParser.params_definition_return();
        retval.Start = input.LT(1);
        int params_definition_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.ident_list_return ident_list70 = default(PascalGrammarParser.ident_list_return);

        PascalGrammarParser.type_return type71 = default(PascalGrammarParser.type_return);


        RewriteRuleSubtreeStream stream_ident_list = new RewriteRuleSubtreeStream(adaptor,"rule ident_list");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:140:2: ( ( ident_list type ) -> ^( type ident_list ) )
            // PascalGrammar.g:141:2: ( ident_list type )
            {
            	// PascalGrammar.g:141:2: ( ident_list type )
            	// PascalGrammar.g:141:3: ident_list type
            	{
            		PushFollow(FOLLOW_ident_list_in_params_definition1042);
            		ident_list70 = ident_list();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_ident_list.Add(ident_list70.Tree);
            		PushFollow(FOLLOW_type_in_params_definition1044);
            		type71 = type();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_type.Add(type71.Tree);

            	}



            	// AST REWRITE
            	// elements:          type, ident_list
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 141:20: -> ^( type ident_list )
            	{
            	    // PascalGrammar.g:141:23: ^( type ident_list )
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
    // PascalGrammar.g:144:1: method_definition : ( ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) | ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) );
    public PascalGrammarParser.method_definition_return method_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.method_definition_return retval = new PascalGrammarParser.method_definition_return();
        retval.Start = input.LT(1);
        int method_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken PROCEDURE72 = null;
        IToken IDENT73 = null;
        IToken char_literal74 = null;
        IToken char_literal76 = null;
        IToken char_literal78 = null;
        IToken SEMICOLON79 = null;
        IToken BLOCKOPEN82 = null;
        IToken BLOCKEND84 = null;
        IToken FUNCTION85 = null;
        IToken IDENT86 = null;
        IToken char_literal87 = null;
        IToken char_literal89 = null;
        IToken char_literal91 = null;
        IToken SEMICOLON93 = null;
        IToken BLOCKOPEN96 = null;
        IToken BLOCKEND98 = null;
        PascalGrammarParser.params_definition_return params_definition75 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.params_definition_return params_definition77 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.methods_definition_return methods_definition80 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition81 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.expr_list_return expr_list83 = default(PascalGrammarParser.expr_list_return);

        PascalGrammarParser.params_definition_return params_definition88 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.params_definition_return params_definition90 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.type_return type92 = default(PascalGrammarParser.type_return);

        PascalGrammarParser.methods_definition_return methods_definition94 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition95 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.expr_list_return expr_list97 = default(PascalGrammarParser.expr_list_return);


        object PROCEDURE72_tree=null;
        object IDENT73_tree=null;
        object char_literal74_tree=null;
        object char_literal76_tree=null;
        object char_literal78_tree=null;
        object SEMICOLON79_tree=null;
        object BLOCKOPEN82_tree=null;
        object BLOCKEND84_tree=null;
        object FUNCTION85_tree=null;
        object IDENT86_tree=null;
        object char_literal87_tree=null;
        object char_literal89_tree=null;
        object char_literal91_tree=null;
        object SEMICOLON93_tree=null;
        object BLOCKOPEN96_tree=null;
        object BLOCKEND98_tree=null;
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
            // PascalGrammar.g:145:2: ( ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) | ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) )
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
                    // PascalGrammar.g:146:2: ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    {
                    	// PascalGrammar.g:146:2: ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    	// PascalGrammar.g:146:3: PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND
                    	{
                    		PROCEDURE72=(IToken)Match(input,PROCEDURE,FOLLOW_PROCEDURE_in_method_definition1068); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_PROCEDURE.Add(PROCEDURE72);

                    		IDENT73=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_method_definition1070); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT73);

                    		// PascalGrammar.g:146:19: ( '(' ( params_definition ( ';' params_definition )* )? ')' )?
                    		int alt18 = 2;
                    		int LA18_0 = input.LA(1);

                    		if ( (LA18_0 == 38) )
                    		{
                    		    alt18 = 1;
                    		}
                    		switch (alt18) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:146:20: '(' ( params_definition ( ';' params_definition )* )? ')'
                    		        {
                    		        	char_literal74=(IToken)Match(input,38,FOLLOW_38_in_method_definition1073); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_38.Add(char_literal74);

                    		        	// PascalGrammar.g:146:24: ( params_definition ( ';' params_definition )* )?
                    		        	int alt17 = 2;
                    		        	int LA17_0 = input.LA(1);

                    		        	if ( (LA17_0 == IDENT) )
                    		        	{
                    		        	    alt17 = 1;
                    		        	}
                    		        	switch (alt17) 
                    		        	{
                    		        	    case 1 :
                    		        	        // PascalGrammar.g:146:25: params_definition ( ';' params_definition )*
                    		        	        {
                    		        	        	PushFollow(FOLLOW_params_definition_in_method_definition1076);
                    		        	        	params_definition75 = params_definition();
                    		        	        	state.followingStackPointer--;
                    		        	        	if (state.failed) return retval;
                    		        	        	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition75.Tree);
                    		        	        	// PascalGrammar.g:146:43: ( ';' params_definition )*
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
                    		        	        			    // PascalGrammar.g:146:44: ';' params_definition
                    		        	        			    {
                    		        	        			    	char_literal76=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1079); if (state.failed) return retval; 
                    		        	        			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(char_literal76);

                    		        	        			    	PushFollow(FOLLOW_params_definition_in_method_definition1081);
                    		        	        			    	params_definition77 = params_definition();
                    		        	        			    	state.followingStackPointer--;
                    		        	        			    	if (state.failed) return retval;
                    		        	        			    	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition77.Tree);

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

                    		        	char_literal78=(IToken)Match(input,39,FOLLOW_39_in_method_definition1087); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_39.Add(char_literal78);


                    		        }
                    		        break;

                    		}

                    		SEMICOLON79=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1091); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON79);

                    		// PascalGrammar.g:146:86: ( methods_definition )?
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
                    		        	PushFollow(FOLLOW_methods_definition_in_method_definition1093);
                    		        	methods_definition80 = methods_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition80.Tree);

                    		        }
                    		        break;

                    		}

                    		// PascalGrammar.g:147:2: ( variables_definition )?
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
                    		        	PushFollow(FOLLOW_variables_definition_in_method_definition1098);
                    		        	variables_definition81 = variables_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition81.Tree);

                    		        }
                    		        break;

                    		}

                    		BLOCKOPEN82=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_method_definition1101); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN82);

                    		PushFollow(FOLLOW_expr_list_in_method_definition1103);
                    		expr_list83 = expr_list();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list83.Tree);
                    		BLOCKEND84=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_method_definition1105); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND84);


                    	}



                    	// AST REWRITE
                    	// elements:          expr_list, params_definition, variables_definition, PROCEDURE, methods_definition
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 148:2: -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	{
                    	    // PascalGrammar.g:148:5: ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new ProcedureAstNode(PROCEDURE, ((IDENT73 != null) ? IDENT73.Text : null)), root_1);

                    	    // PascalGrammar.g:148:48: ( ^( PARAMS ( params_definition )* ) )?
                    	    if ( stream_params_definition.HasNext() )
                    	    {
                    	        // PascalGrammar.g:148:48: ^( PARAMS ( params_definition )* )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

                    	        // PascalGrammar.g:148:57: ( params_definition )*
                    	        while ( stream_params_definition.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_2, stream_params_definition.NextTree());

                    	        }
                    	        stream_params_definition.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_params_definition.Reset();
                    	    // PascalGrammar.g:148:78: ( methods_definition )?
                    	    if ( stream_methods_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

                    	    }
                    	    stream_methods_definition.Reset();
                    	    // PascalGrammar.g:148:98: ( variables_definition )?
                    	    if ( stream_variables_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

                    	    }
                    	    stream_variables_definition.Reset();
                    	    // PascalGrammar.g:148:120: ^( BLOCK expr_list )
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
                    // PascalGrammar.g:150:2: ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    {
                    	// PascalGrammar.g:150:2: ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    	// PascalGrammar.g:150:3: FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND
                    	{
                    		FUNCTION85=(IToken)Match(input,FUNCTION,FOLLOW_FUNCTION_in_method_definition1145); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_FUNCTION.Add(FUNCTION85);

                    		IDENT86=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_method_definition1147); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT86);

                    		// PascalGrammar.g:150:18: ( '(' ( params_definition ( ';' params_definition )* )? ')' )?
                    		int alt23 = 2;
                    		int LA23_0 = input.LA(1);

                    		if ( (LA23_0 == 38) )
                    		{
                    		    alt23 = 1;
                    		}
                    		switch (alt23) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:150:19: '(' ( params_definition ( ';' params_definition )* )? ')'
                    		        {
                    		        	char_literal87=(IToken)Match(input,38,FOLLOW_38_in_method_definition1150); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_38.Add(char_literal87);

                    		        	// PascalGrammar.g:150:23: ( params_definition ( ';' params_definition )* )?
                    		        	int alt22 = 2;
                    		        	int LA22_0 = input.LA(1);

                    		        	if ( (LA22_0 == IDENT) )
                    		        	{
                    		        	    alt22 = 1;
                    		        	}
                    		        	switch (alt22) 
                    		        	{
                    		        	    case 1 :
                    		        	        // PascalGrammar.g:150:24: params_definition ( ';' params_definition )*
                    		        	        {
                    		        	        	PushFollow(FOLLOW_params_definition_in_method_definition1153);
                    		        	        	params_definition88 = params_definition();
                    		        	        	state.followingStackPointer--;
                    		        	        	if (state.failed) return retval;
                    		        	        	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition88.Tree);
                    		        	        	// PascalGrammar.g:150:42: ( ';' params_definition )*
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
                    		        	        			    // PascalGrammar.g:150:43: ';' params_definition
                    		        	        			    {
                    		        	        			    	char_literal89=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1156); if (state.failed) return retval; 
                    		        	        			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(char_literal89);

                    		        	        			    	PushFollow(FOLLOW_params_definition_in_method_definition1158);
                    		        	        			    	params_definition90 = params_definition();
                    		        	        			    	state.followingStackPointer--;
                    		        	        			    	if (state.failed) return retval;
                    		        	        			    	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition90.Tree);

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

                    		        	char_literal91=(IToken)Match(input,39,FOLLOW_39_in_method_definition1164); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_39.Add(char_literal91);


                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_type_in_method_definition1168);
                    		type92 = type();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_type.Add(type92.Tree);
                    		SEMICOLON93=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1170); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON93);

                    		// PascalGrammar.g:150:90: ( methods_definition )?
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
                    		        	PushFollow(FOLLOW_methods_definition_in_method_definition1172);
                    		        	methods_definition94 = methods_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition94.Tree);

                    		        }
                    		        break;

                    		}

                    		// PascalGrammar.g:151:2: ( variables_definition )?
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
                    		        	PushFollow(FOLLOW_variables_definition_in_method_definition1177);
                    		        	variables_definition95 = variables_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition95.Tree);

                    		        }
                    		        break;

                    		}

                    		BLOCKOPEN96=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_method_definition1180); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN96);

                    		PushFollow(FOLLOW_expr_list_in_method_definition1182);
                    		expr_list97 = expr_list();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list97.Tree);
                    		BLOCKEND98=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_method_definition1184); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND98);


                    	}



                    	// AST REWRITE
                    	// elements:          expr_list, variables_definition, params_definition, FUNCTION, methods_definition, type
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 152:2: -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	{
                    	    // PascalGrammar.g:152:5: ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new FunctionAstNode(FUNCTION, ((IDENT86 != null) ? IDENT86.Text : null), ""), root_1);

                    	    adaptor.AddChild(root_1, stream_type.NextTree());
                    	    // PascalGrammar.g:152:55: ( ^( PARAMS ( params_definition )* ) )?
                    	    if ( stream_params_definition.HasNext() )
                    	    {
                    	        // PascalGrammar.g:152:55: ^( PARAMS ( params_definition )* )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

                    	        // PascalGrammar.g:152:64: ( params_definition )*
                    	        while ( stream_params_definition.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_2, stream_params_definition.NextTree());

                    	        }
                    	        stream_params_definition.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_params_definition.Reset();
                    	    // PascalGrammar.g:152:85: ( methods_definition )?
                    	    if ( stream_methods_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

                    	    }
                    	    stream_methods_definition.Reset();
                    	    // PascalGrammar.g:152:105: ( variables_definition )?
                    	    if ( stream_variables_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

                    	    }
                    	    stream_variables_definition.Reset();
                    	    // PascalGrammar.g:152:127: ^( BLOCK expr_list )
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
    // PascalGrammar.g:155:1: methods_definition : method_definition ( SEMICOLON method_definition )* ( SEMICOLON )* -> ^( METHODS ( method_definition )* ) ;
    public PascalGrammarParser.methods_definition_return methods_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.methods_definition_return retval = new PascalGrammarParser.methods_definition_return();
        retval.Start = input.LT(1);
        int methods_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken SEMICOLON100 = null;
        IToken SEMICOLON102 = null;
        PascalGrammarParser.method_definition_return method_definition99 = default(PascalGrammarParser.method_definition_return);

        PascalGrammarParser.method_definition_return method_definition101 = default(PascalGrammarParser.method_definition_return);


        object SEMICOLON100_tree=null;
        object SEMICOLON102_tree=null;
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleSubtreeStream stream_method_definition = new RewriteRuleSubtreeStream(adaptor,"rule method_definition");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:156:2: ( method_definition ( SEMICOLON method_definition )* ( SEMICOLON )* -> ^( METHODS ( method_definition )* ) )
            // PascalGrammar.g:157:2: method_definition ( SEMICOLON method_definition )* ( SEMICOLON )*
            {
            	PushFollow(FOLLOW_method_definition_in_methods_definition1233);
            	method_definition99 = method_definition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_method_definition.Add(method_definition99.Tree);
            	// PascalGrammar.g:157:20: ( SEMICOLON method_definition )*
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
            			    // PascalGrammar.g:157:21: SEMICOLON method_definition
            			    {
            			    	SEMICOLON100=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_methods_definition1236); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON100);

            			    	PushFollow(FOLLOW_method_definition_in_methods_definition1238);
            			    	method_definition101 = method_definition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_method_definition.Add(method_definition101.Tree);

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements

            	// PascalGrammar.g:157:51: ( SEMICOLON )*
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
            			    	SEMICOLON102=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_methods_definition1242); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON102);


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
            	// 157:62: -> ^( METHODS ( method_definition )* )
            	{
            	    // PascalGrammar.g:157:65: ^( METHODS ( method_definition )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METHODS, "METHODS"), root_1);

            	    // PascalGrammar.g:157:75: ( method_definition )*
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
    // PascalGrammar.g:160:1: program : PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.' -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body ) ;
    public PascalGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        PascalGrammarParser.program_return retval = new PascalGrammarParser.program_return();
        retval.Start = input.LT(1);
        int program_StartIndex = input.Index();
        object root_0 = null;

        IToken PROGRAM103 = null;
        IToken IDENT104 = null;
        IToken SEMICOLON105 = null;
        IToken BLOCKOPEN108 = null;
        IToken BLOCKEND110 = null;
        IToken char_literal111 = null;
        PascalGrammarParser.methods_definition_return methods_definition106 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition107 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.program_body_return program_body109 = default(PascalGrammarParser.program_body_return);


        object PROGRAM103_tree=null;
        object IDENT104_tree=null;
        object SEMICOLON105_tree=null;
        object BLOCKOPEN108_tree=null;
        object BLOCKEND110_tree=null;
        object char_literal111_tree=null;
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
            // PascalGrammar.g:161:2: ( PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.' -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body ) )
            // PascalGrammar.g:162:2: PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.'
            {
            	PROGRAM103=(IToken)Match(input,PROGRAM,FOLLOW_PROGRAM_in_program1269); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PROGRAM.Add(PROGRAM103);

            	IDENT104=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_program1271); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT104);

            	SEMICOLON105=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_program1273); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON105);

            	// PascalGrammar.g:162:26: ( methods_definition )?
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
            	        	PushFollow(FOLLOW_methods_definition_in_program1275);
            	        	methods_definition106 = methods_definition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition106.Tree);

            	        }
            	        break;

            	}

            	// PascalGrammar.g:162:46: ( variables_definition )?
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
            	        	PushFollow(FOLLOW_variables_definition_in_program1278);
            	        	variables_definition107 = variables_definition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition107.Tree);

            	        }
            	        break;

            	}

            	BLOCKOPEN108=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_program1282); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN108);

            	PushFollow(FOLLOW_program_body_in_program1284);
            	program_body109 = program_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_program_body.Add(program_body109.Tree);
            	BLOCKEND110=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_program1286); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND110);

            	char_literal111=(IToken)Match(input,42,FOLLOW_42_in_program1288); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal111);



            	// AST REWRITE
            	// elements:          variables_definition, PROGRAM, program_body, methods_definition
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 163:3: -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body )
            	{
            	    // PascalGrammar.g:163:6: ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ProgAstNode(PROGRAM, ((IDENT104 != null) ? IDENT104.Text : null)), root_1);

            	    // PascalGrammar.g:163:42: ( methods_definition )?
            	    if ( stream_methods_definition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

            	    }
            	    stream_methods_definition.Reset();
            	    // PascalGrammar.g:163:62: ( variables_definition )?
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
    // PascalGrammar.g:166:1: result : program ;
    public PascalGrammarParser.result_return result() // throws RecognitionException [1]
    {   
        PascalGrammarParser.result_return retval = new PascalGrammarParser.result_return();
        retval.Start = input.LT(1);
        int result_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.program_return program112 = default(PascalGrammarParser.program_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:167:2: ( program )
            // PascalGrammar.g:168:2: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_result1326);
            	program112 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program112.Tree);

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
    // PascalGrammar.g:171:1: execute : result ;
    public PascalGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        PascalGrammarParser.execute_return retval = new PascalGrammarParser.execute_return();
        retval.Start = input.LT(1);
        int execute_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.result_return result113 = default(PascalGrammarParser.result_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:172:2: ( result )
            // PascalGrammar.g:173:2: result
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_result_in_execute1344);
            	result113 = result();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result113.Tree);

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

    // $ANTLR start "synpred19_PascalGrammar"
    public void synpred19_PascalGrammar_fragment() {
        // PascalGrammar.g:109:28: ( ELSE expr )
        // PascalGrammar.g:109:28: ELSE expr
        {
        	Match(input,ELSE,FOLLOW_ELSE_in_synpred19_PascalGrammar830); if (state.failed) return ;
        	PushFollow(FOLLOW_expr_in_synpred19_PascalGrammar833);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred19_PascalGrammar"

    // Delegated rules

   	public bool synpred19_PascalGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred19_PascalGrammar_fragment(); // can never throw exception
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


   	protected DFA11 dfa11;
	private void InitializeCyclicDFAs()
	{
    	this.dfa11 = new DFA11(this);
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
            get { return "()* loopback of 117:15: ( ( ';' )+ expr )*"; }
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
    public static readonly BitSet FOLLOW_IDENT_in_expr787 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr789 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_term_in_expr792 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_expr797 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_expr802 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_expr804 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_expr806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_expr819 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr822 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_THEN_in_expr824 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr827 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_ELSE_in_expr830 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr840 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr843 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr845 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_add_in_expr848 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_TO_in_expr850 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_add_in_expr853 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_DO_in_expr855 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr863 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr866 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_DO_in_expr868 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr871 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DO_in_expr876 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr879 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr881 = new BitSet(new ulong[]{0x000000405C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list902 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr_list907 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list912 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr_list917 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list923 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_expr_list_in_program_body940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident_list962 = new BitSet(new ulong[]{0x0000010000000002UL});
    public static readonly BitSet FOLLOW_40_in_ident_list965 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident_list968 = new BitSet(new ulong[]{0x0000010000000002UL});
    public static readonly BitSet FOLLOW_41_in_type983 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_type985 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_in_variables_definition1004 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_ident_list_in_variables_definition1007 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_type_in_variables_definition1009 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_variables_definition1011 = new BitSet(new ulong[]{0x0000000008000402UL});
    public static readonly BitSet FOLLOW_ident_list_in_params_definition1042 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_type_in_params_definition1044 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PROCEDURE_in_method_definition1068 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_method_definition1070 = new BitSet(new ulong[]{0x0000004000000400UL});
    public static readonly BitSet FOLLOW_38_in_method_definition1073 = new BitSet(new ulong[]{0x0000008008000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1076 = new BitSet(new ulong[]{0x0000008000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1079 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1081 = new BitSet(new ulong[]{0x0000008000000400UL});
    public static readonly BitSet FOLLOW_39_in_method_definition1087 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1091 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_method_definition1093 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_method_definition1098 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_method_definition1101 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_method_definition1103 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_method_definition1105 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNCTION_in_method_definition1145 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_method_definition1147 = new BitSet(new ulong[]{0x0000024000000000UL});
    public static readonly BitSet FOLLOW_38_in_method_definition1150 = new BitSet(new ulong[]{0x0000008008000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1153 = new BitSet(new ulong[]{0x0000008000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1156 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1158 = new BitSet(new ulong[]{0x0000008000000400UL});
    public static readonly BitSet FOLLOW_39_in_method_definition1164 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_type_in_method_definition1168 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1170 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_method_definition1172 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_method_definition1177 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_method_definition1180 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_method_definition1182 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_method_definition1184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_method_definition_in_methods_definition1233 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_methods_definition1236 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_method_definition_in_methods_definition1238 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_methods_definition1242 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_PROGRAM_in_program1269 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_program1271 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_program1273 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_program1275 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_program1278 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_program1282 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_program_body_in_program1284 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_program1286 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_program1288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_result1326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_result_in_execute1344 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_synpred19_PascalGrammar830 = new BitSet(new ulong[]{0x0000000008690C00UL});
    public static readonly BitSet FOLLOW_expr_in_synpred19_PascalGrammar833 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}