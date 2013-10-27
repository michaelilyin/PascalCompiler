// $ANTLR 3.2 Sep 23, 2009 12:02:23 PascalGrammar.g 2013-10-27 19:17:34

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

    public const int FUNCTION = 13;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int XOR = 25;
    public const int WHILE = 22;
    public const int TO = 20;
    public const int ELSE = 18;
    public const int NUMBER = 27;
    public const int DO = 21;
    public const int FOR = 19;
    public const int SUB = 32;
    public const int SEMICOLON = 10;
    public const int AND = 23;
    public const int EOF = -1;
    public const int MUL = 33;
    public const int PROCEDURE = 14;
    public const int IF = 16;
    public const int FUNC_CALL = 15;
    public const int BLOCKOPEN = 11;
    public const int WS = 30;
    public const int THEN = 17;
    public const int METHODS = 8;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int STRING_CONST = 9;
    public const int BLOCK = 6;
    public const int BLOCKEND = 12;
    public const int OR = 24;
    public const int ASSIGN = 35;
    public const int COMPARE = 36;
    public const int IDENT = 26;
    public const int PROGRAM = 4;
    public const int VAR = 5;
    public const int DIV = 34;
    public const int COMMENT = 28;
    public const int STRING = 29;
    public const int ADD = 31;
    public const int PARAMS = 7;

    // delegates
    // delegators



        public PascalGrammarParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PascalGrammarParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[62+1];
             
             
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
    // PascalGrammar.g:79:1: group : ( '(' term ')' | NUMBER -> NUMBER[double.Parse($NUMBER.text, NFI)] | func_call | IDENT | STRING -> STRING[$STRING.text] );
    public PascalGrammarParser.group_return group() // throws RecognitionException [1]
    {   
        PascalGrammarParser.group_return retval = new PascalGrammarParser.group_return();
        retval.Start = input.LT(1);
        int group_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal1 = null;
        IToken char_literal3 = null;
        IToken NUMBER4 = null;
        IToken IDENT6 = null;
        IToken STRING7 = null;
        PascalGrammarParser.term_return term2 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.func_call_return func_call5 = default(PascalGrammarParser.func_call_return);


        object char_literal1_tree=null;
        object char_literal3_tree=null;
        object NUMBER4_tree=null;
        object IDENT6_tree=null;
        object STRING7_tree=null;
        RewriteRuleTokenStream stream_STRING = new RewriteRuleTokenStream(adaptor,"token STRING");
        RewriteRuleTokenStream stream_NUMBER = new RewriteRuleTokenStream(adaptor,"token NUMBER");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:80:2: ( '(' term ')' | NUMBER -> NUMBER[double.Parse($NUMBER.text, NFI)] | func_call | IDENT | STRING -> STRING[$STRING.text] )
            int alt1 = 5;
            switch ( input.LA(1) ) 
            {
            case 37:
            	{
                alt1 = 1;
                }
                break;
            case NUMBER:
            	{
                alt1 = 2;
                }
                break;
            case IDENT:
            	{
                int LA1_3 = input.LA(2);

                if ( (LA1_3 == 37) )
                {
                    alt1 = 3;
                }
                else if ( (LA1_3 == EOF || LA1_3 == SEMICOLON || LA1_3 == BLOCKEND || (LA1_3 >= THEN && LA1_3 <= ELSE) || (LA1_3 >= TO && LA1_3 <= XOR) || (LA1_3 >= ADD && LA1_3 <= DIV) || LA1_3 == COMPARE || (LA1_3 >= 38 && LA1_3 <= 39)) )
                {
                    alt1 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d1s3 =
                        new NoViableAltException("", 1, 3, input);

                    throw nvae_d1s3;
                }
                }
                break;
            case STRING:
            	{
                alt1 = 5;
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
                    // PascalGrammar.g:81:2: '(' term ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal1=(IToken)Match(input,37,FOLLOW_37_in_group555); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_group558);
                    	term2 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
                    	char_literal3=(IToken)Match(input,38,FOLLOW_38_in_group560); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:82:4: NUMBER
                    {
                    	NUMBER4=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_group566); if (state.failed) return retval; 
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
                    	// 82:11: -> NUMBER[double.Parse($NUMBER.text, NFI)]
                    	{
                    	    adaptor.AddChild(root_0, new NumAstNode(NUMBER, double.Parse(((NUMBER4 != null) ? NUMBER4.Text : null), NFI)));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // PascalGrammar.g:83:4: func_call
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_group579);
                    	func_call5 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call5.Tree);

                    }
                    break;
                case 4 :
                    // PascalGrammar.g:84:4: IDENT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT6=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_group584); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT6_tree = (object)adaptor.Create(IDENT6);
                    		adaptor.AddChild(root_0, IDENT6_tree);
                    	}

                    }
                    break;
                case 5 :
                    // PascalGrammar.g:85:4: STRING
                    {
                    	STRING7=(IToken)Match(input,STRING,FOLLOW_STRING_in_group589); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_STRING.Add(STRING7);



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
                    	// 85:11: -> STRING[$STRING.text]
                    	{
                    	    adaptor.AddChild(root_0, new StringAstNode(STRING, ((STRING7 != null) ? STRING7.Text : null)));

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
    // PascalGrammar.g:88:1: mult : group ( ( MUL | DIV | AND ) group )* ;
    public PascalGrammarParser.mult_return mult() // throws RecognitionException [1]
    {   
        PascalGrammarParser.mult_return retval = new PascalGrammarParser.mult_return();
        retval.Start = input.LT(1);
        int mult_StartIndex = input.Index();
        object root_0 = null;

        IToken set9 = null;
        PascalGrammarParser.group_return group8 = default(PascalGrammarParser.group_return);

        PascalGrammarParser.group_return group10 = default(PascalGrammarParser.group_return);


        object set9_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:88:5: ( group ( ( MUL | DIV | AND ) group )* )
            // PascalGrammar.g:88:7: group ( ( MUL | DIV | AND ) group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult612);
            	group8 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group8.Tree);
            	// PascalGrammar.g:88:13: ( ( MUL | DIV | AND ) group )*
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
            			    // PascalGrammar.g:88:15: ( MUL | DIV | AND ) group
            			    {
            			    	set9=(IToken)input.LT(1);
            			    	set9 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == AND || (input.LA(1) >= MUL && input.LA(1) <= DIV) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set9), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_group_in_mult631);
            			    	group10 = group();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group10.Tree);

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
    // PascalGrammar.g:89:1: add : mult ( ( ADD | SUB | OR | XOR ) mult )* ;
    public PascalGrammarParser.add_return add() // throws RecognitionException [1]
    {   
        PascalGrammarParser.add_return retval = new PascalGrammarParser.add_return();
        retval.Start = input.LT(1);
        int add_StartIndex = input.Index();
        object root_0 = null;

        IToken set12 = null;
        PascalGrammarParser.mult_return mult11 = default(PascalGrammarParser.mult_return);

        PascalGrammarParser.mult_return mult13 = default(PascalGrammarParser.mult_return);


        object set12_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:89:4: ( mult ( ( ADD | SUB | OR | XOR ) mult )* )
            // PascalGrammar.g:89:7: mult ( ( ADD | SUB | OR | XOR ) mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add643);
            	mult11 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult11.Tree);
            	// PascalGrammar.g:89:13: ( ( ADD | SUB | OR | XOR ) mult )*
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
            			    // PascalGrammar.g:89:15: ( ADD | SUB | OR | XOR ) mult
            			    {
            			    	set12=(IToken)input.LT(1);
            			    	set12 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= OR && input.LA(1) <= XOR) || (input.LA(1) >= ADD && input.LA(1) <= SUB) ) 
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

            			    	PushFollow(FOLLOW_mult_in_add667);
            			    	mult13 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult13.Tree);

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
    // PascalGrammar.g:90:1: compare : add ( COMPARE add )* ;
    public PascalGrammarParser.compare_return compare() // throws RecognitionException [1]
    {   
        PascalGrammarParser.compare_return retval = new PascalGrammarParser.compare_return();
        retval.Start = input.LT(1);
        int compare_StartIndex = input.Index();
        object root_0 = null;

        IToken COMPARE15 = null;
        PascalGrammarParser.add_return add14 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.add_return add16 = default(PascalGrammarParser.add_return);


        object COMPARE15_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:90:9: ( add ( COMPARE add )* )
            // PascalGrammar.g:90:11: add ( COMPARE add )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_compare680);
            	add14 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add14.Tree);
            	// PascalGrammar.g:90:15: ( COMPARE add )*
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
            			    // PascalGrammar.g:90:17: COMPARE add
            			    {
            			    	COMPARE15=(IToken)Match(input,COMPARE,FOLLOW_COMPARE_in_compare684); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMPARE15_tree = (object)adaptor.Create(COMPARE15);
            			    		root_0 = (object)adaptor.BecomeRoot(COMPARE15_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_add_in_compare687);
            			    	add16 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add16.Tree);

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
    // PascalGrammar.g:91:1: term : compare ;
    public PascalGrammarParser.term_return term() // throws RecognitionException [1]
    {   
        PascalGrammarParser.term_return retval = new PascalGrammarParser.term_return();
        retval.Start = input.LT(1);
        int term_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.compare_return compare17 = default(PascalGrammarParser.compare_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:91:6: ( compare )
            // PascalGrammar.g:91:8: compare
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_compare_in_term696);
            	compare17 = compare();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare17.Tree);

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
    // PascalGrammar.g:93:1: arg_list : ( term ( ',' term )* )? ;
    public PascalGrammarParser.arg_list_return arg_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.arg_list_return retval = new PascalGrammarParser.arg_list_return();
        retval.Start = input.LT(1);
        int arg_list_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal19 = null;
        PascalGrammarParser.term_return term18 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.term_return term20 = default(PascalGrammarParser.term_return);


        object char_literal19_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:93:9: ( ( term ( ',' term )* )? )
            // PascalGrammar.g:93:11: ( term ( ',' term )* )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// PascalGrammar.g:93:11: ( term ( ',' term )* )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( ((LA6_0 >= IDENT && LA6_0 <= NUMBER) || LA6_0 == STRING || LA6_0 == 37) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:93:13: term ( ',' term )*
            	        {
            	        	PushFollow(FOLLOW_term_in_arg_list705);
            	        	term18 = term();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term18.Tree);
            	        	// PascalGrammar.g:93:18: ( ',' term )*
            	        	do 
            	        	{
            	        	    int alt5 = 2;
            	        	    int LA5_0 = input.LA(1);

            	        	    if ( (LA5_0 == 39) )
            	        	    {
            	        	        alt5 = 1;
            	        	    }


            	        	    switch (alt5) 
            	        		{
            	        			case 1 :
            	        			    // PascalGrammar.g:93:19: ',' term
            	        			    {
            	        			    	char_literal19=(IToken)Match(input,39,FOLLOW_39_in_arg_list708); if (state.failed) return retval;
            	        			    	PushFollow(FOLLOW_term_in_arg_list711);
            	        			    	term20 = term();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term20.Tree);

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
    // PascalGrammar.g:95:1: func_call : IDENT ( '(' arg_list ')' ) -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? ) ;
    public PascalGrammarParser.func_call_return func_call() // throws RecognitionException [1]
    {   
        PascalGrammarParser.func_call_return retval = new PascalGrammarParser.func_call_return();
        retval.Start = input.LT(1);
        int func_call_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT21 = null;
        IToken char_literal22 = null;
        IToken char_literal24 = null;
        PascalGrammarParser.arg_list_return arg_list23 = default(PascalGrammarParser.arg_list_return);


        object IDENT21_tree=null;
        object char_literal22_tree=null;
        object char_literal24_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_arg_list = new RewriteRuleSubtreeStream(adaptor,"rule arg_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:96:2: ( IDENT ( '(' arg_list ')' ) -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? ) )
            // PascalGrammar.g:97:2: IDENT ( '(' arg_list ')' )
            {
            	IDENT21=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_func_call727); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT21);

            	// PascalGrammar.g:97:8: ( '(' arg_list ')' )
            	// PascalGrammar.g:97:9: '(' arg_list ')'
            	{
            		char_literal22=(IToken)Match(input,37,FOLLOW_37_in_func_call730); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_37.Add(char_literal22);

            		PushFollow(FOLLOW_arg_list_in_func_call732);
            		arg_list23 = arg_list();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_arg_list.Add(arg_list23.Tree);
            		char_literal24=(IToken)Match(input,38,FOLLOW_38_in_func_call734); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_38.Add(char_literal24);


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
            	// 97:28: -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? )
            	{
            	    // PascalGrammar.g:97:31: ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // PascalGrammar.g:97:49: ( ^( PARAMS arg_list ) )?
            	    if ( stream_arg_list.HasNext() )
            	    {
            	        // PascalGrammar.g:97:49: ^( PARAMS arg_list )
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
    // PascalGrammar.g:100:1: expr : ( IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare );
    public PascalGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        PascalGrammarParser.expr_return retval = new PascalGrammarParser.expr_return();
        retval.Start = input.LT(1);
        int expr_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT25 = null;
        IToken ASSIGN26 = null;
        IToken BLOCKOPEN29 = null;
        IToken BLOCKEND31 = null;
        IToken IF32 = null;
        IToken THEN34 = null;
        IToken ELSE36 = null;
        IToken FOR38 = null;
        IToken IDENT39 = null;
        IToken ASSIGN40 = null;
        IToken TO42 = null;
        IToken DO44 = null;
        IToken WHILE46 = null;
        IToken DO48 = null;
        IToken DO50 = null;
        IToken WHILE52 = null;
        PascalGrammarParser.term_return term27 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.func_call_return func_call28 = default(PascalGrammarParser.func_call_return);

        PascalGrammarParser.expr_list_return expr_list30 = default(PascalGrammarParser.expr_list_return);

        PascalGrammarParser.compare_return compare33 = default(PascalGrammarParser.compare_return);

        PascalGrammarParser.expr_return expr35 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr37 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.add_return add41 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.add_return add43 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.expr_return expr45 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.compare_return compare47 = default(PascalGrammarParser.compare_return);

        PascalGrammarParser.expr_return expr49 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr51 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.compare_return compare53 = default(PascalGrammarParser.compare_return);


        object IDENT25_tree=null;
        object ASSIGN26_tree=null;
        object BLOCKOPEN29_tree=null;
        object BLOCKEND31_tree=null;
        object IF32_tree=null;
        object THEN34_tree=null;
        object ELSE36_tree=null;
        object FOR38_tree=null;
        object IDENT39_tree=null;
        object ASSIGN40_tree=null;
        object TO42_tree=null;
        object DO44_tree=null;
        object WHILE46_tree=null;
        object DO48_tree=null;
        object DO50_tree=null;
        object WHILE52_tree=null;
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:100:6: ( IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare )
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
                else if ( (LA8_1 == 37) )
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
                    // PascalGrammar.g:101:2: IDENT ASSIGN term
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT25=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr762); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT25_tree = (object)adaptor.Create(IDENT25);
                    		adaptor.AddChild(root_0, IDENT25_tree);
                    	}
                    	ASSIGN26=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr764); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN26_tree = (object)adaptor.Create(ASSIGN26);
                    		root_0 = (object)adaptor.BecomeRoot(ASSIGN26_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr767);
                    	term27 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term27.Tree);

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:102:4: func_call
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_expr772);
                    	func_call28 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call28.Tree);

                    }
                    break;
                case 3 :
                    // PascalGrammar.g:103:4: BLOCKOPEN expr_list BLOCKEND
                    {
                    	BLOCKOPEN29=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_expr777); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN29);

                    	PushFollow(FOLLOW_expr_list_in_expr779);
                    	expr_list30 = expr_list();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list30.Tree);
                    	BLOCKEND31=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_expr781); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND31);



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
                    	// 103:33: -> ^( BLOCK expr_list )
                    	{
                    	    // PascalGrammar.g:103:36: ^( BLOCK expr_list )
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
                    // PascalGrammar.g:104:4: IF compare THEN expr ( ELSE expr )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IF32=(IToken)Match(input,IF,FOLLOW_IF_in_expr794); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IF32_tree = (object)adaptor.Create(IF32);
                    		root_0 = (object)adaptor.BecomeRoot(IF32_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_compare_in_expr797);
                    	compare33 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare33.Tree);
                    	THEN34=(IToken)Match(input,THEN,FOLLOW_THEN_in_expr799); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr802);
                    	expr35 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr35.Tree);
                    	// PascalGrammar.g:104:27: ( ELSE expr )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == ELSE) )
                    	{
                    	    int LA7_1 = input.LA(2);

                    	    if ( (synpred18_PascalGrammar()) )
                    	    {
                    	        alt7 = 1;
                    	    }
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // PascalGrammar.g:104:28: ELSE expr
                    	        {
                    	        	ELSE36=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_expr805); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_expr_in_expr808);
                    	        	expr37 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr37.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 5 :
                    // PascalGrammar.g:105:4: FOR IDENT ASSIGN add TO add DO expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FOR38=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr815); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FOR38_tree = (object)adaptor.Create(FOR38);
                    		root_0 = (object)adaptor.BecomeRoot(FOR38_tree, root_0);
                    	}
                    	IDENT39=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr818); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT39_tree = (object)adaptor.Create(IDENT39);
                    		adaptor.AddChild(root_0, IDENT39_tree);
                    	}
                    	ASSIGN40=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr820); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_expr823);
                    	add41 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add41.Tree);
                    	TO42=(IToken)Match(input,TO,FOLLOW_TO_in_expr825); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_expr828);
                    	add43 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add43.Tree);
                    	DO44=(IToken)Match(input,DO,FOLLOW_DO_in_expr830); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr833);
                    	expr45 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr45.Tree);

                    }
                    break;
                case 6 :
                    // PascalGrammar.g:106:4: WHILE compare DO expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	WHILE46=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr838); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WHILE46_tree = (object)adaptor.Create(WHILE46);
                    		root_0 = (object)adaptor.BecomeRoot(WHILE46_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_compare_in_expr841);
                    	compare47 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare47.Tree);
                    	DO48=(IToken)Match(input,DO,FOLLOW_DO_in_expr843); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr846);
                    	expr49 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr49.Tree);

                    }
                    break;
                case 7 :
                    // PascalGrammar.g:107:4: DO expr WHILE compare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	DO50=(IToken)Match(input,DO,FOLLOW_DO_in_expr851); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DO50_tree = (object)adaptor.Create(DO50);
                    		root_0 = (object)adaptor.BecomeRoot(DO50_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_expr_in_expr854);
                    	expr51 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr51.Tree);
                    	WHILE52=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr856); if (state.failed) return retval;
                    	PushFollow(FOLLOW_compare_in_expr859);
                    	compare53 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare53.Tree);

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
    // PascalGrammar.g:110:1: expr_list : ( ';' )* expr ( ( ';' )+ expr )* ( ';' )* ;
    public PascalGrammarParser.expr_list_return expr_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.expr_list_return retval = new PascalGrammarParser.expr_list_return();
        retval.Start = input.LT(1);
        int expr_list_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal54 = null;
        IToken char_literal56 = null;
        IToken char_literal58 = null;
        PascalGrammarParser.expr_return expr55 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr57 = default(PascalGrammarParser.expr_return);


        object char_literal54_tree=null;
        object char_literal56_tree=null;
        object char_literal58_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:111:2: ( ( ';' )* expr ( ( ';' )+ expr )* ( ';' )* )
            // PascalGrammar.g:112:2: ( ';' )* expr ( ( ';' )+ expr )* ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// PascalGrammar.g:112:2: ( ';' )*
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
            			    // PascalGrammar.g:112:3: ';'
            			    {
            			    	char_literal54=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list877); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	PushFollow(FOLLOW_expr_in_expr_list882);
            	expr55 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr55.Tree);
            	// PascalGrammar.g:112:15: ( ( ';' )+ expr )*
            	do 
            	{
            	    int alt11 = 2;
            	    alt11 = dfa11.Predict(input);
            	    switch (alt11) 
            		{
            			case 1 :
            			    // PascalGrammar.g:112:17: ( ';' )+ expr
            			    {
            			    	// PascalGrammar.g:112:17: ( ';' )+
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
            			    			    // PascalGrammar.g:112:18: ';'
            			    			    {
            			    			    	char_literal56=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list887); if (state.failed) return retval;

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

            			    	PushFollow(FOLLOW_expr_in_expr_list892);
            			    	expr57 = expr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr57.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	// PascalGrammar.g:112:33: ( ';' )*
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
            			    // PascalGrammar.g:112:34: ';'
            			    {
            			    	char_literal58=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list898); if (state.failed) return retval;

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
    // PascalGrammar.g:115:1: program_body : expr_list -> ^( BLOCK expr_list ) ;
    public PascalGrammarParser.program_body_return program_body() // throws RecognitionException [1]
    {   
        PascalGrammarParser.program_body_return retval = new PascalGrammarParser.program_body_return();
        retval.Start = input.LT(1);
        int program_body_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.expr_list_return expr_list59 = default(PascalGrammarParser.expr_list_return);


        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:116:2: ( expr_list -> ^( BLOCK expr_list ) )
            // PascalGrammar.g:117:2: expr_list
            {
            	PushFollow(FOLLOW_expr_list_in_program_body915);
            	expr_list59 = expr_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list59.Tree);


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
            	// 117:12: -> ^( BLOCK expr_list )
            	{
            	    // PascalGrammar.g:117:15: ^( BLOCK expr_list )
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
    // PascalGrammar.g:120:1: ident_list : IDENT ( ',' IDENT )* ;
    public PascalGrammarParser.ident_list_return ident_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.ident_list_return retval = new PascalGrammarParser.ident_list_return();
        retval.Start = input.LT(1);
        int ident_list_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT60 = null;
        IToken char_literal61 = null;
        IToken IDENT62 = null;

        object IDENT60_tree=null;
        object char_literal61_tree=null;
        object IDENT62_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:121:2: ( IDENT ( ',' IDENT )* )
            // PascalGrammar.g:122:2: IDENT ( ',' IDENT )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IDENT60=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident_list937); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IDENT60_tree = (object)adaptor.Create(IDENT60);
            		adaptor.AddChild(root_0, IDENT60_tree);
            	}
            	// PascalGrammar.g:122:8: ( ',' IDENT )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == 39) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // PascalGrammar.g:122:9: ',' IDENT
            			    {
            			    	char_literal61=(IToken)Match(input,39,FOLLOW_39_in_ident_list940); if (state.failed) return retval;
            			    	IDENT62=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident_list943); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{IDENT62_tree = (object)adaptor.Create(IDENT62);
            			    		adaptor.AddChild(root_0, IDENT62_tree);
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
    // PascalGrammar.g:125:1: type : ':' IDENT -> ^( IDENT ) ;
    public PascalGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        PascalGrammarParser.type_return retval = new PascalGrammarParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal63 = null;
        IToken IDENT64 = null;

        object char_literal63_tree=null;
        object IDENT64_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:125:6: ( ':' IDENT -> ^( IDENT ) )
            // PascalGrammar.g:126:2: ':' IDENT
            {
            	char_literal63=(IToken)Match(input,40,FOLLOW_40_in_type958); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal63);

            	IDENT64=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_type960); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT64);



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
            	// 126:12: -> ^( IDENT )
            	{
            	    // PascalGrammar.g:126:15: ^( IDENT )
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
    // PascalGrammar.g:129:1: variables_definition : VAR ( ident_list type ( SEMICOLON )+ )+ -> ^( VAR ( ^( type ident_list ) )+ ) ;
    public PascalGrammarParser.variables_definition_return variables_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.variables_definition_return retval = new PascalGrammarParser.variables_definition_return();
        retval.Start = input.LT(1);
        int variables_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken VAR65 = null;
        IToken SEMICOLON68 = null;
        PascalGrammarParser.ident_list_return ident_list66 = default(PascalGrammarParser.ident_list_return);

        PascalGrammarParser.type_return type67 = default(PascalGrammarParser.type_return);


        object VAR65_tree=null;
        object SEMICOLON68_tree=null;
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
            // PascalGrammar.g:130:2: ( VAR ( ident_list type ( SEMICOLON )+ )+ -> ^( VAR ( ^( type ident_list ) )+ ) )
            // PascalGrammar.g:131:2: VAR ( ident_list type ( SEMICOLON )+ )+
            {
            	VAR65=(IToken)Match(input,VAR,FOLLOW_VAR_in_variables_definition979); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_VAR.Add(VAR65);

            	// PascalGrammar.g:131:6: ( ident_list type ( SEMICOLON )+ )+
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
            			    // PascalGrammar.g:131:7: ident_list type ( SEMICOLON )+
            			    {
            			    	PushFollow(FOLLOW_ident_list_in_variables_definition982);
            			    	ident_list66 = ident_list();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_ident_list.Add(ident_list66.Tree);
            			    	PushFollow(FOLLOW_type_in_variables_definition984);
            			    	type67 = type();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_type.Add(type67.Tree);
            			    	// PascalGrammar.g:131:23: ( SEMICOLON )+
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
            			    			    	SEMICOLON68=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_variables_definition986); if (state.failed) return retval; 
            			    			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON68);


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
            	// 131:36: -> ^( VAR ( ^( type ident_list ) )+ )
            	{
            	    // PascalGrammar.g:131:39: ^( VAR ( ^( type ident_list ) )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

            	    if ( !(stream_ident_list.HasNext() || stream_type.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_ident_list.HasNext() || stream_type.HasNext() )
            	    {
            	        // PascalGrammar.g:131:45: ^( type ident_list )
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
    // PascalGrammar.g:134:1: params_definition : ( ident_list type ) -> ^( type ident_list ) ;
    public PascalGrammarParser.params_definition_return params_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.params_definition_return retval = new PascalGrammarParser.params_definition_return();
        retval.Start = input.LT(1);
        int params_definition_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.ident_list_return ident_list69 = default(PascalGrammarParser.ident_list_return);

        PascalGrammarParser.type_return type70 = default(PascalGrammarParser.type_return);


        RewriteRuleSubtreeStream stream_ident_list = new RewriteRuleSubtreeStream(adaptor,"rule ident_list");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:135:2: ( ( ident_list type ) -> ^( type ident_list ) )
            // PascalGrammar.g:136:2: ( ident_list type )
            {
            	// PascalGrammar.g:136:2: ( ident_list type )
            	// PascalGrammar.g:136:3: ident_list type
            	{
            		PushFollow(FOLLOW_ident_list_in_params_definition1017);
            		ident_list69 = ident_list();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_ident_list.Add(ident_list69.Tree);
            		PushFollow(FOLLOW_type_in_params_definition1019);
            		type70 = type();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_type.Add(type70.Tree);

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
            	// 136:20: -> ^( type ident_list )
            	{
            	    // PascalGrammar.g:136:23: ^( type ident_list )
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
    // PascalGrammar.g:139:1: method_definition : ( ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) | ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) );
    public PascalGrammarParser.method_definition_return method_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.method_definition_return retval = new PascalGrammarParser.method_definition_return();
        retval.Start = input.LT(1);
        int method_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken PROCEDURE71 = null;
        IToken IDENT72 = null;
        IToken char_literal73 = null;
        IToken char_literal75 = null;
        IToken char_literal77 = null;
        IToken SEMICOLON78 = null;
        IToken BLOCKOPEN81 = null;
        IToken BLOCKEND83 = null;
        IToken FUNCTION84 = null;
        IToken IDENT85 = null;
        IToken char_literal86 = null;
        IToken char_literal88 = null;
        IToken char_literal90 = null;
        IToken SEMICOLON92 = null;
        IToken BLOCKOPEN95 = null;
        IToken BLOCKEND97 = null;
        PascalGrammarParser.params_definition_return params_definition74 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.params_definition_return params_definition76 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.methods_definition_return methods_definition79 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition80 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.expr_list_return expr_list82 = default(PascalGrammarParser.expr_list_return);

        PascalGrammarParser.params_definition_return params_definition87 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.params_definition_return params_definition89 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.type_return type91 = default(PascalGrammarParser.type_return);

        PascalGrammarParser.methods_definition_return methods_definition93 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition94 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.expr_list_return expr_list96 = default(PascalGrammarParser.expr_list_return);


        object PROCEDURE71_tree=null;
        object IDENT72_tree=null;
        object char_literal73_tree=null;
        object char_literal75_tree=null;
        object char_literal77_tree=null;
        object SEMICOLON78_tree=null;
        object BLOCKOPEN81_tree=null;
        object BLOCKEND83_tree=null;
        object FUNCTION84_tree=null;
        object IDENT85_tree=null;
        object char_literal86_tree=null;
        object char_literal88_tree=null;
        object char_literal90_tree=null;
        object SEMICOLON92_tree=null;
        object BLOCKOPEN95_tree=null;
        object BLOCKEND97_tree=null;
        RewriteRuleTokenStream stream_FUNCTION = new RewriteRuleTokenStream(adaptor,"token FUNCTION");
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_PROCEDURE = new RewriteRuleTokenStream(adaptor,"token PROCEDURE");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");
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
            // PascalGrammar.g:140:2: ( ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) | ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) )
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
                    // PascalGrammar.g:141:2: ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    {
                    	// PascalGrammar.g:141:2: ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    	// PascalGrammar.g:141:3: PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND
                    	{
                    		PROCEDURE71=(IToken)Match(input,PROCEDURE,FOLLOW_PROCEDURE_in_method_definition1043); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_PROCEDURE.Add(PROCEDURE71);

                    		IDENT72=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_method_definition1045); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT72);

                    		// PascalGrammar.g:141:19: ( '(' ( params_definition ( ';' params_definition )* )? ')' )?
                    		int alt18 = 2;
                    		int LA18_0 = input.LA(1);

                    		if ( (LA18_0 == 37) )
                    		{
                    		    alt18 = 1;
                    		}
                    		switch (alt18) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:141:20: '(' ( params_definition ( ';' params_definition )* )? ')'
                    		        {
                    		        	char_literal73=(IToken)Match(input,37,FOLLOW_37_in_method_definition1048); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_37.Add(char_literal73);

                    		        	// PascalGrammar.g:141:24: ( params_definition ( ';' params_definition )* )?
                    		        	int alt17 = 2;
                    		        	int LA17_0 = input.LA(1);

                    		        	if ( (LA17_0 == IDENT) )
                    		        	{
                    		        	    alt17 = 1;
                    		        	}
                    		        	switch (alt17) 
                    		        	{
                    		        	    case 1 :
                    		        	        // PascalGrammar.g:141:25: params_definition ( ';' params_definition )*
                    		        	        {
                    		        	        	PushFollow(FOLLOW_params_definition_in_method_definition1051);
                    		        	        	params_definition74 = params_definition();
                    		        	        	state.followingStackPointer--;
                    		        	        	if (state.failed) return retval;
                    		        	        	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition74.Tree);
                    		        	        	// PascalGrammar.g:141:43: ( ';' params_definition )*
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
                    		        	        			    // PascalGrammar.g:141:44: ';' params_definition
                    		        	        			    {
                    		        	        			    	char_literal75=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1054); if (state.failed) return retval; 
                    		        	        			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(char_literal75);

                    		        	        			    	PushFollow(FOLLOW_params_definition_in_method_definition1056);
                    		        	        			    	params_definition76 = params_definition();
                    		        	        			    	state.followingStackPointer--;
                    		        	        			    	if (state.failed) return retval;
                    		        	        			    	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition76.Tree);

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

                    		        	char_literal77=(IToken)Match(input,38,FOLLOW_38_in_method_definition1062); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_38.Add(char_literal77);


                    		        }
                    		        break;

                    		}

                    		SEMICOLON78=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1066); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON78);

                    		// PascalGrammar.g:141:86: ( methods_definition )?
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
                    		        	PushFollow(FOLLOW_methods_definition_in_method_definition1068);
                    		        	methods_definition79 = methods_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition79.Tree);

                    		        }
                    		        break;

                    		}

                    		// PascalGrammar.g:142:2: ( variables_definition )?
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
                    		        	PushFollow(FOLLOW_variables_definition_in_method_definition1073);
                    		        	variables_definition80 = variables_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition80.Tree);

                    		        }
                    		        break;

                    		}

                    		BLOCKOPEN81=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_method_definition1076); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN81);

                    		PushFollow(FOLLOW_expr_list_in_method_definition1078);
                    		expr_list82 = expr_list();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list82.Tree);
                    		BLOCKEND83=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_method_definition1080); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND83);


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
                    	// 143:2: -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	{
                    	    // PascalGrammar.g:143:5: ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new ProcedureAstNode(PROCEDURE, ((IDENT72 != null) ? IDENT72.Text : null)), root_1);

                    	    // PascalGrammar.g:143:48: ( ^( PARAMS ( params_definition )* ) )?
                    	    if ( stream_params_definition.HasNext() )
                    	    {
                    	        // PascalGrammar.g:143:48: ^( PARAMS ( params_definition )* )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

                    	        // PascalGrammar.g:143:57: ( params_definition )*
                    	        while ( stream_params_definition.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_2, stream_params_definition.NextTree());

                    	        }
                    	        stream_params_definition.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_params_definition.Reset();
                    	    // PascalGrammar.g:143:78: ( methods_definition )?
                    	    if ( stream_methods_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

                    	    }
                    	    stream_methods_definition.Reset();
                    	    // PascalGrammar.g:143:98: ( variables_definition )?
                    	    if ( stream_variables_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

                    	    }
                    	    stream_variables_definition.Reset();
                    	    // PascalGrammar.g:143:120: ^( BLOCK expr_list )
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
                    // PascalGrammar.g:145:2: ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    {
                    	// PascalGrammar.g:145:2: ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    	// PascalGrammar.g:145:3: FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND
                    	{
                    		FUNCTION84=(IToken)Match(input,FUNCTION,FOLLOW_FUNCTION_in_method_definition1120); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_FUNCTION.Add(FUNCTION84);

                    		IDENT85=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_method_definition1122); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT85);

                    		// PascalGrammar.g:145:18: ( '(' ( params_definition ( ';' params_definition )* )? ')' )?
                    		int alt23 = 2;
                    		int LA23_0 = input.LA(1);

                    		if ( (LA23_0 == 37) )
                    		{
                    		    alt23 = 1;
                    		}
                    		switch (alt23) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:145:19: '(' ( params_definition ( ';' params_definition )* )? ')'
                    		        {
                    		        	char_literal86=(IToken)Match(input,37,FOLLOW_37_in_method_definition1125); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_37.Add(char_literal86);

                    		        	// PascalGrammar.g:145:23: ( params_definition ( ';' params_definition )* )?
                    		        	int alt22 = 2;
                    		        	int LA22_0 = input.LA(1);

                    		        	if ( (LA22_0 == IDENT) )
                    		        	{
                    		        	    alt22 = 1;
                    		        	}
                    		        	switch (alt22) 
                    		        	{
                    		        	    case 1 :
                    		        	        // PascalGrammar.g:145:24: params_definition ( ';' params_definition )*
                    		        	        {
                    		        	        	PushFollow(FOLLOW_params_definition_in_method_definition1128);
                    		        	        	params_definition87 = params_definition();
                    		        	        	state.followingStackPointer--;
                    		        	        	if (state.failed) return retval;
                    		        	        	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition87.Tree);
                    		        	        	// PascalGrammar.g:145:42: ( ';' params_definition )*
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
                    		        	        			    // PascalGrammar.g:145:43: ';' params_definition
                    		        	        			    {
                    		        	        			    	char_literal88=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1131); if (state.failed) return retval; 
                    		        	        			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(char_literal88);

                    		        	        			    	PushFollow(FOLLOW_params_definition_in_method_definition1133);
                    		        	        			    	params_definition89 = params_definition();
                    		        	        			    	state.followingStackPointer--;
                    		        	        			    	if (state.failed) return retval;
                    		        	        			    	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition89.Tree);

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

                    		        	char_literal90=(IToken)Match(input,38,FOLLOW_38_in_method_definition1139); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_38.Add(char_literal90);


                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_type_in_method_definition1143);
                    		type91 = type();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_type.Add(type91.Tree);
                    		SEMICOLON92=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1145); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON92);

                    		// PascalGrammar.g:145:90: ( methods_definition )?
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
                    		        	PushFollow(FOLLOW_methods_definition_in_method_definition1147);
                    		        	methods_definition93 = methods_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition93.Tree);

                    		        }
                    		        break;

                    		}

                    		// PascalGrammar.g:146:2: ( variables_definition )?
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
                    		        	PushFollow(FOLLOW_variables_definition_in_method_definition1152);
                    		        	variables_definition94 = variables_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition94.Tree);

                    		        }
                    		        break;

                    		}

                    		BLOCKOPEN95=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_method_definition1155); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN95);

                    		PushFollow(FOLLOW_expr_list_in_method_definition1157);
                    		expr_list96 = expr_list();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list96.Tree);
                    		BLOCKEND97=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_method_definition1159); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND97);


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
                    	// 147:2: -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	{
                    	    // PascalGrammar.g:147:5: ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new FunctionAstNode(FUNCTION, ((IDENT85 != null) ? IDENT85.Text : null), ""), root_1);

                    	    adaptor.AddChild(root_1, stream_type.NextTree());
                    	    // PascalGrammar.g:147:55: ( ^( PARAMS ( params_definition )* ) )?
                    	    if ( stream_params_definition.HasNext() )
                    	    {
                    	        // PascalGrammar.g:147:55: ^( PARAMS ( params_definition )* )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

                    	        // PascalGrammar.g:147:64: ( params_definition )*
                    	        while ( stream_params_definition.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_2, stream_params_definition.NextTree());

                    	        }
                    	        stream_params_definition.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_params_definition.Reset();
                    	    // PascalGrammar.g:147:85: ( methods_definition )?
                    	    if ( stream_methods_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

                    	    }
                    	    stream_methods_definition.Reset();
                    	    // PascalGrammar.g:147:105: ( variables_definition )?
                    	    if ( stream_variables_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

                    	    }
                    	    stream_variables_definition.Reset();
                    	    // PascalGrammar.g:147:127: ^( BLOCK expr_list )
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
    // PascalGrammar.g:150:1: methods_definition : method_definition ( SEMICOLON method_definition )* ( SEMICOLON )* -> ^( METHODS ( method_definition )* ) ;
    public PascalGrammarParser.methods_definition_return methods_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.methods_definition_return retval = new PascalGrammarParser.methods_definition_return();
        retval.Start = input.LT(1);
        int methods_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken SEMICOLON99 = null;
        IToken SEMICOLON101 = null;
        PascalGrammarParser.method_definition_return method_definition98 = default(PascalGrammarParser.method_definition_return);

        PascalGrammarParser.method_definition_return method_definition100 = default(PascalGrammarParser.method_definition_return);


        object SEMICOLON99_tree=null;
        object SEMICOLON101_tree=null;
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleSubtreeStream stream_method_definition = new RewriteRuleSubtreeStream(adaptor,"rule method_definition");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:151:2: ( method_definition ( SEMICOLON method_definition )* ( SEMICOLON )* -> ^( METHODS ( method_definition )* ) )
            // PascalGrammar.g:152:2: method_definition ( SEMICOLON method_definition )* ( SEMICOLON )*
            {
            	PushFollow(FOLLOW_method_definition_in_methods_definition1208);
            	method_definition98 = method_definition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_method_definition.Add(method_definition98.Tree);
            	// PascalGrammar.g:152:20: ( SEMICOLON method_definition )*
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
            			    // PascalGrammar.g:152:21: SEMICOLON method_definition
            			    {
            			    	SEMICOLON99=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_methods_definition1211); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON99);

            			    	PushFollow(FOLLOW_method_definition_in_methods_definition1213);
            			    	method_definition100 = method_definition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_method_definition.Add(method_definition100.Tree);

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements

            	// PascalGrammar.g:152:51: ( SEMICOLON )*
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
            			    	SEMICOLON101=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_methods_definition1217); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON101);


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
            	// 152:62: -> ^( METHODS ( method_definition )* )
            	{
            	    // PascalGrammar.g:152:65: ^( METHODS ( method_definition )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METHODS, "METHODS"), root_1);

            	    // PascalGrammar.g:152:75: ( method_definition )*
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
    // PascalGrammar.g:155:1: program : PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.' -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body ) ;
    public PascalGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        PascalGrammarParser.program_return retval = new PascalGrammarParser.program_return();
        retval.Start = input.LT(1);
        int program_StartIndex = input.Index();
        object root_0 = null;

        IToken PROGRAM102 = null;
        IToken IDENT103 = null;
        IToken SEMICOLON104 = null;
        IToken BLOCKOPEN107 = null;
        IToken BLOCKEND109 = null;
        IToken char_literal110 = null;
        PascalGrammarParser.methods_definition_return methods_definition105 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition106 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.program_body_return program_body108 = default(PascalGrammarParser.program_body_return);


        object PROGRAM102_tree=null;
        object IDENT103_tree=null;
        object SEMICOLON104_tree=null;
        object BLOCKOPEN107_tree=null;
        object BLOCKEND109_tree=null;
        object char_literal110_tree=null;
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_PROGRAM = new RewriteRuleTokenStream(adaptor,"token PROGRAM");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
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
            // PascalGrammar.g:156:2: ( PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.' -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body ) )
            // PascalGrammar.g:157:2: PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.'
            {
            	PROGRAM102=(IToken)Match(input,PROGRAM,FOLLOW_PROGRAM_in_program1244); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PROGRAM.Add(PROGRAM102);

            	IDENT103=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_program1246); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT103);

            	SEMICOLON104=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_program1248); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON104);

            	// PascalGrammar.g:157:26: ( methods_definition )?
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
            	        	PushFollow(FOLLOW_methods_definition_in_program1250);
            	        	methods_definition105 = methods_definition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition105.Tree);

            	        }
            	        break;

            	}

            	// PascalGrammar.g:157:46: ( variables_definition )?
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
            	        	PushFollow(FOLLOW_variables_definition_in_program1253);
            	        	variables_definition106 = variables_definition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition106.Tree);

            	        }
            	        break;

            	}

            	BLOCKOPEN107=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_program1257); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN107);

            	PushFollow(FOLLOW_program_body_in_program1259);
            	program_body108 = program_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_program_body.Add(program_body108.Tree);
            	BLOCKEND109=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_program1261); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND109);

            	char_literal110=(IToken)Match(input,41,FOLLOW_41_in_program1263); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(char_literal110);



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
            	// 158:3: -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body )
            	{
            	    // PascalGrammar.g:158:6: ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ProgAstNode(PROGRAM, ((IDENT103 != null) ? IDENT103.Text : null)), root_1);

            	    // PascalGrammar.g:158:42: ( methods_definition )?
            	    if ( stream_methods_definition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

            	    }
            	    stream_methods_definition.Reset();
            	    // PascalGrammar.g:158:62: ( variables_definition )?
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
    // PascalGrammar.g:161:1: result : program ;
    public PascalGrammarParser.result_return result() // throws RecognitionException [1]
    {   
        PascalGrammarParser.result_return retval = new PascalGrammarParser.result_return();
        retval.Start = input.LT(1);
        int result_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.program_return program111 = default(PascalGrammarParser.program_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:162:2: ( program )
            // PascalGrammar.g:163:2: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_result1301);
            	program111 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program111.Tree);

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
    // PascalGrammar.g:166:1: execute : result ;
    public PascalGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        PascalGrammarParser.execute_return retval = new PascalGrammarParser.execute_return();
        retval.Start = input.LT(1);
        int execute_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.result_return result112 = default(PascalGrammarParser.result_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:167:2: ( result )
            // PascalGrammar.g:168:2: result
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_result_in_execute1319);
            	result112 = result();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result112.Tree);

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

    // $ANTLR start "synpred18_PascalGrammar"
    public void synpred18_PascalGrammar_fragment() {
        // PascalGrammar.g:104:28: ( ELSE expr )
        // PascalGrammar.g:104:28: ELSE expr
        {
        	Match(input,ELSE,FOLLOW_ELSE_in_synpred18_PascalGrammar805); if (state.failed) return ;
        	PushFollow(FOLLOW_expr_in_synpred18_PascalGrammar808);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred18_PascalGrammar"

    // Delegated rules

   	public bool synpred18_PascalGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred18_PascalGrammar_fragment(); // can never throw exception
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
        "\x01\x0c\x01\x1a\x02\uffff";
    const string DFA11_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA11_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x01\x01\uffff\x01\x02",
            "\x01\x01\x01\x03\x01\x02\x03\uffff\x01\x03\x02\uffff\x01\x03"+
            "\x01\uffff\x02\x03\x03\uffff\x01\x03",
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
            get { return "()* loopback of 112:15: ( ( ';' )+ expr )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_37_in_group555 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_term_in_group558 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_group560 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_group566 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_group579 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_group584 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_group589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult612 = new BitSet(new ulong[]{0x0000000600800002UL});
    public static readonly BitSet FOLLOW_set_in_mult616 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_group_in_mult631 = new BitSet(new ulong[]{0x0000000600800002UL});
    public static readonly BitSet FOLLOW_mult_in_add643 = new BitSet(new ulong[]{0x0000000183000002UL});
    public static readonly BitSet FOLLOW_set_in_add648 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_mult_in_add667 = new BitSet(new ulong[]{0x0000000183000002UL});
    public static readonly BitSet FOLLOW_add_in_compare680 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_COMPARE_in_compare684 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_add_in_compare687 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_compare_in_term696 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_arg_list705 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_39_in_arg_list708 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_term_in_arg_list711 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_func_call727 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_func_call730 = new BitSet(new ulong[]{0x000000602C000000UL});
    public static readonly BitSet FOLLOW_arg_list_in_func_call732 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_func_call734 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr762 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr764 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_term_in_expr767 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_expr772 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_expr777 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_expr779 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_expr781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_expr794 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr797 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_THEN_in_expr799 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr802 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_ELSE_in_expr805 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr808 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr815 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr818 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr820 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_add_in_expr823 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_TO_in_expr825 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_add_in_expr828 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_DO_in_expr830 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr838 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr841 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_DO_in_expr843 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr846 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DO_in_expr851 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr854 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr856 = new BitSet(new ulong[]{0x000000202C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr859 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list877 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr_list882 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list887 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr_list892 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list898 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_expr_list_in_program_body915 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident_list937 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_39_in_ident_list940 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident_list943 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_40_in_type958 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_type960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_in_variables_definition979 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_ident_list_in_variables_definition982 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_type_in_variables_definition984 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_variables_definition986 = new BitSet(new ulong[]{0x0000000004000402UL});
    public static readonly BitSet FOLLOW_ident_list_in_params_definition1017 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_type_in_params_definition1019 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PROCEDURE_in_method_definition1043 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_method_definition1045 = new BitSet(new ulong[]{0x0000002000000400UL});
    public static readonly BitSet FOLLOW_37_in_method_definition1048 = new BitSet(new ulong[]{0x0000004004000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1051 = new BitSet(new ulong[]{0x0000004000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1054 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1056 = new BitSet(new ulong[]{0x0000004000000400UL});
    public static readonly BitSet FOLLOW_38_in_method_definition1062 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1066 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_method_definition1068 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_method_definition1073 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_method_definition1076 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_method_definition1078 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_method_definition1080 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNCTION_in_method_definition1120 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_method_definition1122 = new BitSet(new ulong[]{0x0000012000000000UL});
    public static readonly BitSet FOLLOW_37_in_method_definition1125 = new BitSet(new ulong[]{0x0000004004000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1128 = new BitSet(new ulong[]{0x0000004000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1131 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1133 = new BitSet(new ulong[]{0x0000004000000400UL});
    public static readonly BitSet FOLLOW_38_in_method_definition1139 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_type_in_method_definition1143 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1145 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_method_definition1147 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_method_definition1152 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_method_definition1155 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_method_definition1157 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_method_definition1159 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_method_definition_in_methods_definition1208 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_methods_definition1211 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_method_definition_in_methods_definition1213 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_methods_definition1217 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_PROGRAM_in_program1244 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_program1246 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_program1248 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_program1250 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_program1253 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_program1257 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_program_body_in_program1259 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_program1261 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_program1263 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_result1301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_result_in_execute1319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_synpred18_PascalGrammar805 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_synpred18_PascalGrammar808 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}