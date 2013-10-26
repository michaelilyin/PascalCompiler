// $ANTLR 3.2 Sep 23, 2009 12:02:23 PascalGrammar.g 2013-10-14 18:11:02

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
    public const int XOR = 25;
    public const int WHILE = 22;
    public const int TO = 20;
    public const int ELSE = 18;
    public const int NUMBER = 27;
    public const int DO = 21;
    public const int FOR = 19;
    public const int SUB = 31;
    public const int SEMICOLON = 10;
    public const int AND = 23;
    public const int EOF = -1;
    public const int MUL = 32;
    public const int PROCEDURE = 14;
    public const int IF = 16;
    public const int FUNC_CALL = 15;
    public const int BLOCKOPEN = 11;
    public const int WS = 29;
    public const int THEN = 17;
    public const int METHODS = 8;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int STRING_CONST = 9;
    public const int BLOCK = 6;
    public const int BLOCKEND = 12;
    public const int OR = 24;
    public const int ASSIGN = 34;
    public const int COMPARE = 35;
    public const int IDENT = 26;
    public const int PROGRAM = 4;
    public const int VAR = 5;
    public const int DIV = 33;
    public const int COMMENT = 28;
    public const int ADD = 30;
    public const int PARAMS = 7;

    // delegates
    // delegators



        public PascalGrammarParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public PascalGrammarParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[61+1];
             
             
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
    // PascalGrammar.g:77:1: group : ( '(' term ')' | NUMBER -> NUMBER[double.Parse($NUMBER.text, NFI)] | func_call | IDENT );
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
        PascalGrammarParser.term_return term2 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.func_call_return func_call5 = default(PascalGrammarParser.func_call_return);


        object char_literal1_tree=null;
        object char_literal3_tree=null;
        object NUMBER4_tree=null;
        object IDENT6_tree=null;
        RewriteRuleTokenStream stream_NUMBER = new RewriteRuleTokenStream(adaptor,"token NUMBER");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:78:2: ( '(' term ')' | NUMBER -> NUMBER[double.Parse($NUMBER.text, NFI)] | func_call | IDENT )
            int alt1 = 4;
            switch ( input.LA(1) ) 
            {
            case 36:
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

                if ( (LA1_3 == EOF || LA1_3 == SEMICOLON || LA1_3 == BLOCKEND || (LA1_3 >= THEN && LA1_3 <= ELSE) || (LA1_3 >= TO && LA1_3 <= XOR) || (LA1_3 >= ADD && LA1_3 <= DIV) || LA1_3 == COMPARE || (LA1_3 >= 37 && LA1_3 <= 38)) )
                {
                    alt1 = 4;
                }
                else if ( (LA1_3 == 36) )
                {
                    alt1 = 3;
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
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // PascalGrammar.g:79:2: '(' term ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal1=(IToken)Match(input,36,FOLLOW_36_in_group530); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_group533);
                    	term2 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
                    	char_literal3=(IToken)Match(input,37,FOLLOW_37_in_group535); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:80:4: NUMBER
                    {
                    	NUMBER4=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_group541); if (state.failed) return retval; 
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
                    	// 80:11: -> NUMBER[double.Parse($NUMBER.text, NFI)]
                    	{
                    	    adaptor.AddChild(root_0, new NumAstNode(NUMBER, double.Parse(((NUMBER4 != null) ? NUMBER4.Text : null), NFI)));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // PascalGrammar.g:81:4: func_call
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_group554);
                    	func_call5 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call5.Tree);

                    }
                    break;
                case 4 :
                    // PascalGrammar.g:82:4: IDENT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT6=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_group559); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT6_tree = (object)adaptor.Create(IDENT6);
                    		adaptor.AddChild(root_0, IDENT6_tree);
                    	}

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
    // PascalGrammar.g:86:1: mult : group ( ( MUL | DIV | AND ) group )* ;
    public PascalGrammarParser.mult_return mult() // throws RecognitionException [1]
    {   
        PascalGrammarParser.mult_return retval = new PascalGrammarParser.mult_return();
        retval.Start = input.LT(1);
        int mult_StartIndex = input.Index();
        object root_0 = null;

        IToken set8 = null;
        PascalGrammarParser.group_return group7 = default(PascalGrammarParser.group_return);

        PascalGrammarParser.group_return group9 = default(PascalGrammarParser.group_return);


        object set8_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:86:5: ( group ( ( MUL | DIV | AND ) group )* )
            // PascalGrammar.g:86:7: group ( ( MUL | DIV | AND ) group )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_group_in_mult576);
            	group7 = group();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group7.Tree);
            	// PascalGrammar.g:86:13: ( ( MUL | DIV | AND ) group )*
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
            			    // PascalGrammar.g:86:15: ( MUL | DIV | AND ) group
            			    {
            			    	set8=(IToken)input.LT(1);
            			    	set8 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == AND || (input.LA(1) >= MUL && input.LA(1) <= DIV) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set8), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_group_in_mult595);
            			    	group9 = group();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group9.Tree);

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
    // PascalGrammar.g:87:1: add : mult ( ( ADD | SUB | OR | XOR ) mult )* ;
    public PascalGrammarParser.add_return add() // throws RecognitionException [1]
    {   
        PascalGrammarParser.add_return retval = new PascalGrammarParser.add_return();
        retval.Start = input.LT(1);
        int add_StartIndex = input.Index();
        object root_0 = null;

        IToken set11 = null;
        PascalGrammarParser.mult_return mult10 = default(PascalGrammarParser.mult_return);

        PascalGrammarParser.mult_return mult12 = default(PascalGrammarParser.mult_return);


        object set11_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:87:4: ( mult ( ( ADD | SUB | OR | XOR ) mult )* )
            // PascalGrammar.g:87:7: mult ( ( ADD | SUB | OR | XOR ) mult )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add607);
            	mult10 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult10.Tree);
            	// PascalGrammar.g:87:13: ( ( ADD | SUB | OR | XOR ) mult )*
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
            			    // PascalGrammar.g:87:15: ( ADD | SUB | OR | XOR ) mult
            			    {
            			    	set11=(IToken)input.LT(1);
            			    	set11 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= OR && input.LA(1) <= XOR) || (input.LA(1) >= ADD && input.LA(1) <= SUB) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set11), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_mult_in_add631);
            			    	mult12 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult12.Tree);

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
    // PascalGrammar.g:88:1: compare : add ( COMPARE add )* ;
    public PascalGrammarParser.compare_return compare() // throws RecognitionException [1]
    {   
        PascalGrammarParser.compare_return retval = new PascalGrammarParser.compare_return();
        retval.Start = input.LT(1);
        int compare_StartIndex = input.Index();
        object root_0 = null;

        IToken COMPARE14 = null;
        PascalGrammarParser.add_return add13 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.add_return add15 = default(PascalGrammarParser.add_return);


        object COMPARE14_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:88:9: ( add ( COMPARE add )* )
            // PascalGrammar.g:88:11: add ( COMPARE add )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_compare644);
            	add13 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add13.Tree);
            	// PascalGrammar.g:88:15: ( COMPARE add )*
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
            			    // PascalGrammar.g:88:17: COMPARE add
            			    {
            			    	COMPARE14=(IToken)Match(input,COMPARE,FOLLOW_COMPARE_in_compare648); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMPARE14_tree = (object)adaptor.Create(COMPARE14);
            			    		root_0 = (object)adaptor.BecomeRoot(COMPARE14_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_add_in_compare651);
            			    	add15 = add();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add15.Tree);

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
    // PascalGrammar.g:89:1: term : compare ;
    public PascalGrammarParser.term_return term() // throws RecognitionException [1]
    {   
        PascalGrammarParser.term_return retval = new PascalGrammarParser.term_return();
        retval.Start = input.LT(1);
        int term_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.compare_return compare16 = default(PascalGrammarParser.compare_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:89:6: ( compare )
            // PascalGrammar.g:89:8: compare
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_compare_in_term660);
            	compare16 = compare();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare16.Tree);

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
    // PascalGrammar.g:91:1: arg_list : ( term ( ',' term )* )? ;
    public PascalGrammarParser.arg_list_return arg_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.arg_list_return retval = new PascalGrammarParser.arg_list_return();
        retval.Start = input.LT(1);
        int arg_list_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal18 = null;
        PascalGrammarParser.term_return term17 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.term_return term19 = default(PascalGrammarParser.term_return);


        object char_literal18_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:91:9: ( ( term ( ',' term )* )? )
            // PascalGrammar.g:91:11: ( term ( ',' term )* )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// PascalGrammar.g:91:11: ( term ( ',' term )* )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( ((LA6_0 >= IDENT && LA6_0 <= NUMBER) || LA6_0 == 36) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:91:13: term ( ',' term )*
            	        {
            	        	PushFollow(FOLLOW_term_in_arg_list669);
            	        	term17 = term();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term17.Tree);
            	        	// PascalGrammar.g:91:18: ( ',' term )*
            	        	do 
            	        	{
            	        	    int alt5 = 2;
            	        	    int LA5_0 = input.LA(1);

            	        	    if ( (LA5_0 == 38) )
            	        	    {
            	        	        alt5 = 1;
            	        	    }


            	        	    switch (alt5) 
            	        		{
            	        			case 1 :
            	        			    // PascalGrammar.g:91:19: ',' term
            	        			    {
            	        			    	char_literal18=(IToken)Match(input,38,FOLLOW_38_in_arg_list672); if (state.failed) return retval;
            	        			    	PushFollow(FOLLOW_term_in_arg_list675);
            	        			    	term19 = term();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term19.Tree);

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
    // PascalGrammar.g:93:1: func_call : IDENT ( '(' arg_list ')' ) -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? ) ;
    public PascalGrammarParser.func_call_return func_call() // throws RecognitionException [1]
    {   
        PascalGrammarParser.func_call_return retval = new PascalGrammarParser.func_call_return();
        retval.Start = input.LT(1);
        int func_call_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT20 = null;
        IToken char_literal21 = null;
        IToken char_literal23 = null;
        PascalGrammarParser.arg_list_return arg_list22 = default(PascalGrammarParser.arg_list_return);


        object IDENT20_tree=null;
        object char_literal21_tree=null;
        object char_literal23_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");
        RewriteRuleSubtreeStream stream_arg_list = new RewriteRuleSubtreeStream(adaptor,"rule arg_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:94:2: ( IDENT ( '(' arg_list ')' ) -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? ) )
            // PascalGrammar.g:95:2: IDENT ( '(' arg_list ')' )
            {
            	IDENT20=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_func_call691); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT20);

            	// PascalGrammar.g:95:8: ( '(' arg_list ')' )
            	// PascalGrammar.g:95:9: '(' arg_list ')'
            	{
            		char_literal21=(IToken)Match(input,36,FOLLOW_36_in_func_call694); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_36.Add(char_literal21);

            		PushFollow(FOLLOW_arg_list_in_func_call696);
            		arg_list22 = arg_list();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_arg_list.Add(arg_list22.Tree);
            		char_literal23=(IToken)Match(input,37,FOLLOW_37_in_func_call698); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_37.Add(char_literal23);


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
            	// 95:28: -> ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? )
            	{
            	    // PascalGrammar.g:95:31: ^( FUNC_CALL IDENT ( ^( PARAMS arg_list ) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_IDENT.NextNode());
            	    // PascalGrammar.g:95:49: ( ^( PARAMS arg_list ) )?
            	    if ( stream_arg_list.HasNext() )
            	    {
            	        // PascalGrammar.g:95:49: ^( PARAMS arg_list )
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
    // PascalGrammar.g:98:1: expr : ( IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare );
    public PascalGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        PascalGrammarParser.expr_return retval = new PascalGrammarParser.expr_return();
        retval.Start = input.LT(1);
        int expr_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT24 = null;
        IToken ASSIGN25 = null;
        IToken BLOCKOPEN28 = null;
        IToken BLOCKEND30 = null;
        IToken IF31 = null;
        IToken THEN33 = null;
        IToken ELSE35 = null;
        IToken FOR37 = null;
        IToken IDENT38 = null;
        IToken ASSIGN39 = null;
        IToken TO41 = null;
        IToken DO43 = null;
        IToken WHILE45 = null;
        IToken DO47 = null;
        IToken DO49 = null;
        IToken WHILE51 = null;
        PascalGrammarParser.term_return term26 = default(PascalGrammarParser.term_return);

        PascalGrammarParser.func_call_return func_call27 = default(PascalGrammarParser.func_call_return);

        PascalGrammarParser.expr_list_return expr_list29 = default(PascalGrammarParser.expr_list_return);

        PascalGrammarParser.compare_return compare32 = default(PascalGrammarParser.compare_return);

        PascalGrammarParser.expr_return expr34 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr36 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.add_return add40 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.add_return add42 = default(PascalGrammarParser.add_return);

        PascalGrammarParser.expr_return expr44 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.compare_return compare46 = default(PascalGrammarParser.compare_return);

        PascalGrammarParser.expr_return expr48 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr50 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.compare_return compare52 = default(PascalGrammarParser.compare_return);


        object IDENT24_tree=null;
        object ASSIGN25_tree=null;
        object BLOCKOPEN28_tree=null;
        object BLOCKEND30_tree=null;
        object IF31_tree=null;
        object THEN33_tree=null;
        object ELSE35_tree=null;
        object FOR37_tree=null;
        object IDENT38_tree=null;
        object ASSIGN39_tree=null;
        object TO41_tree=null;
        object DO43_tree=null;
        object WHILE45_tree=null;
        object DO47_tree=null;
        object DO49_tree=null;
        object WHILE51_tree=null;
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:98:6: ( IDENT ASSIGN term | func_call | BLOCKOPEN expr_list BLOCKEND -> ^( BLOCK expr_list ) | IF compare THEN expr ( ELSE expr )? | FOR IDENT ASSIGN add TO add DO expr | WHILE compare DO expr | DO expr WHILE compare )
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
                else if ( (LA8_1 == 36) )
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
                    // PascalGrammar.g:99:2: IDENT ASSIGN term
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IDENT24=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr726); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT24_tree = (object)adaptor.Create(IDENT24);
                    		adaptor.AddChild(root_0, IDENT24_tree);
                    	}
                    	ASSIGN25=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr728); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN25_tree = (object)adaptor.Create(ASSIGN25);
                    		root_0 = (object)adaptor.BecomeRoot(ASSIGN25_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr731);
                    	term26 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term26.Tree);

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:101:4: func_call
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_call_in_expr737);
                    	func_call27 = func_call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_call27.Tree);

                    }
                    break;
                case 3 :
                    // PascalGrammar.g:102:4: BLOCKOPEN expr_list BLOCKEND
                    {
                    	BLOCKOPEN28=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_expr742); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN28);

                    	PushFollow(FOLLOW_expr_list_in_expr744);
                    	expr_list29 = expr_list();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list29.Tree);
                    	BLOCKEND30=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_expr746); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND30);



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
                    	// 102:33: -> ^( BLOCK expr_list )
                    	{
                    	    // PascalGrammar.g:102:36: ^( BLOCK expr_list )
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
                    // PascalGrammar.g:103:4: IF compare THEN expr ( ELSE expr )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IF31=(IToken)Match(input,IF,FOLLOW_IF_in_expr759); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IF31_tree = (object)adaptor.Create(IF31);
                    		root_0 = (object)adaptor.BecomeRoot(IF31_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_compare_in_expr762);
                    	compare32 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare32.Tree);
                    	THEN33=(IToken)Match(input,THEN,FOLLOW_THEN_in_expr764); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr767);
                    	expr34 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr34.Tree);
                    	// PascalGrammar.g:103:27: ( ELSE expr )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == ELSE) )
                    	{
                    	    int LA7_1 = input.LA(2);

                    	    if ( (synpred17_PascalGrammar()) )
                    	    {
                    	        alt7 = 1;
                    	    }
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // PascalGrammar.g:103:28: ELSE expr
                    	        {
                    	        	ELSE35=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_expr770); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_expr_in_expr773);
                    	        	expr36 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr36.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 5 :
                    // PascalGrammar.g:104:4: FOR IDENT ASSIGN add TO add DO expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FOR37=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr780); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FOR37_tree = (object)adaptor.Create(FOR37);
                    		root_0 = (object)adaptor.BecomeRoot(FOR37_tree, root_0);
                    	}
                    	IDENT38=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_expr783); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENT38_tree = (object)adaptor.Create(IDENT38);
                    		adaptor.AddChild(root_0, IDENT38_tree);
                    	}
                    	ASSIGN39=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr785); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_expr788);
                    	add40 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add40.Tree);
                    	TO41=(IToken)Match(input,TO,FOLLOW_TO_in_expr790); if (state.failed) return retval;
                    	PushFollow(FOLLOW_add_in_expr793);
                    	add42 = add();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add42.Tree);
                    	DO43=(IToken)Match(input,DO,FOLLOW_DO_in_expr795); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr798);
                    	expr44 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr44.Tree);

                    }
                    break;
                case 6 :
                    // PascalGrammar.g:105:4: WHILE compare DO expr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	WHILE45=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr803); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WHILE45_tree = (object)adaptor.Create(WHILE45);
                    		root_0 = (object)adaptor.BecomeRoot(WHILE45_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_compare_in_expr806);
                    	compare46 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare46.Tree);
                    	DO47=(IToken)Match(input,DO,FOLLOW_DO_in_expr808); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr811);
                    	expr48 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr48.Tree);

                    }
                    break;
                case 7 :
                    // PascalGrammar.g:106:4: DO expr WHILE compare
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	DO49=(IToken)Match(input,DO,FOLLOW_DO_in_expr816); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{DO49_tree = (object)adaptor.Create(DO49);
                    		root_0 = (object)adaptor.BecomeRoot(DO49_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_expr_in_expr819);
                    	expr50 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr50.Tree);
                    	WHILE51=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr821); if (state.failed) return retval;
                    	PushFollow(FOLLOW_compare_in_expr824);
                    	compare52 = compare();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare52.Tree);

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
    // PascalGrammar.g:109:1: expr_list : ( ';' )* expr ( ( ';' )+ expr )* ( ';' )* ;
    public PascalGrammarParser.expr_list_return expr_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.expr_list_return retval = new PascalGrammarParser.expr_list_return();
        retval.Start = input.LT(1);
        int expr_list_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal53 = null;
        IToken char_literal55 = null;
        IToken char_literal57 = null;
        PascalGrammarParser.expr_return expr54 = default(PascalGrammarParser.expr_return);

        PascalGrammarParser.expr_return expr56 = default(PascalGrammarParser.expr_return);


        object char_literal53_tree=null;
        object char_literal55_tree=null;
        object char_literal57_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:110:2: ( ( ';' )* expr ( ( ';' )+ expr )* ( ';' )* )
            // PascalGrammar.g:111:2: ( ';' )* expr ( ( ';' )+ expr )* ( ';' )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// PascalGrammar.g:111:2: ( ';' )*
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
            			    // PascalGrammar.g:111:3: ';'
            			    {
            			    	char_literal53=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list842); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	PushFollow(FOLLOW_expr_in_expr_list847);
            	expr54 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr54.Tree);
            	// PascalGrammar.g:111:15: ( ( ';' )+ expr )*
            	do 
            	{
            	    int alt11 = 2;
            	    alt11 = dfa11.Predict(input);
            	    switch (alt11) 
            		{
            			case 1 :
            			    // PascalGrammar.g:111:17: ( ';' )+ expr
            			    {
            			    	// PascalGrammar.g:111:17: ( ';' )+
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
            			    			    // PascalGrammar.g:111:18: ';'
            			    			    {
            			    			    	char_literal55=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list852); if (state.failed) return retval;

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

            			    	PushFollow(FOLLOW_expr_in_expr_list857);
            			    	expr56 = expr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr56.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	// PascalGrammar.g:111:33: ( ';' )*
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
            			    // PascalGrammar.g:111:34: ';'
            			    {
            			    	char_literal57=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_expr_list863); if (state.failed) return retval;

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
    // PascalGrammar.g:114:1: program_body : expr_list -> ^( BLOCK expr_list ) ;
    public PascalGrammarParser.program_body_return program_body() // throws RecognitionException [1]
    {   
        PascalGrammarParser.program_body_return retval = new PascalGrammarParser.program_body_return();
        retval.Start = input.LT(1);
        int program_body_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.expr_list_return expr_list58 = default(PascalGrammarParser.expr_list_return);


        RewriteRuleSubtreeStream stream_expr_list = new RewriteRuleSubtreeStream(adaptor,"rule expr_list");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:115:2: ( expr_list -> ^( BLOCK expr_list ) )
            // PascalGrammar.g:116:2: expr_list
            {
            	PushFollow(FOLLOW_expr_list_in_program_body880);
            	expr_list58 = expr_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list58.Tree);


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
            	// 116:12: -> ^( BLOCK expr_list )
            	{
            	    // PascalGrammar.g:116:15: ^( BLOCK expr_list )
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
    // PascalGrammar.g:119:1: ident_list : IDENT ( ',' IDENT )* ;
    public PascalGrammarParser.ident_list_return ident_list() // throws RecognitionException [1]
    {   
        PascalGrammarParser.ident_list_return retval = new PascalGrammarParser.ident_list_return();
        retval.Start = input.LT(1);
        int ident_list_StartIndex = input.Index();
        object root_0 = null;

        IToken IDENT59 = null;
        IToken char_literal60 = null;
        IToken IDENT61 = null;

        object IDENT59_tree=null;
        object char_literal60_tree=null;
        object IDENT61_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:120:2: ( IDENT ( ',' IDENT )* )
            // PascalGrammar.g:121:2: IDENT ( ',' IDENT )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IDENT59=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident_list902); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IDENT59_tree = (object)adaptor.Create(IDENT59);
            		adaptor.AddChild(root_0, IDENT59_tree);
            	}
            	// PascalGrammar.g:121:8: ( ',' IDENT )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == 38) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // PascalGrammar.g:121:9: ',' IDENT
            			    {
            			    	char_literal60=(IToken)Match(input,38,FOLLOW_38_in_ident_list905); if (state.failed) return retval;
            			    	IDENT61=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident_list908); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{IDENT61_tree = (object)adaptor.Create(IDENT61);
            			    		adaptor.AddChild(root_0, IDENT61_tree);
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
    // PascalGrammar.g:124:1: type : ':' IDENT -> ^( IDENT ) ;
    public PascalGrammarParser.type_return type() // throws RecognitionException [1]
    {   
        PascalGrammarParser.type_return retval = new PascalGrammarParser.type_return();
        retval.Start = input.LT(1);
        int type_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal62 = null;
        IToken IDENT63 = null;

        object char_literal62_tree=null;
        object IDENT63_tree=null;
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:124:6: ( ':' IDENT -> ^( IDENT ) )
            // PascalGrammar.g:125:2: ':' IDENT
            {
            	char_literal62=(IToken)Match(input,39,FOLLOW_39_in_type923); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(char_literal62);

            	IDENT63=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_type925); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT63);



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
            	// 125:12: -> ^( IDENT )
            	{
            	    // PascalGrammar.g:125:15: ^( IDENT )
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
    // PascalGrammar.g:128:1: variables_definition : VAR ( ident_list type ( SEMICOLON )+ )+ -> ^( VAR ( ^( type ident_list ) )+ ) ;
    public PascalGrammarParser.variables_definition_return variables_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.variables_definition_return retval = new PascalGrammarParser.variables_definition_return();
        retval.Start = input.LT(1);
        int variables_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken VAR64 = null;
        IToken SEMICOLON67 = null;
        PascalGrammarParser.ident_list_return ident_list65 = default(PascalGrammarParser.ident_list_return);

        PascalGrammarParser.type_return type66 = default(PascalGrammarParser.type_return);


        object VAR64_tree=null;
        object SEMICOLON67_tree=null;
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
            // PascalGrammar.g:129:2: ( VAR ( ident_list type ( SEMICOLON )+ )+ -> ^( VAR ( ^( type ident_list ) )+ ) )
            // PascalGrammar.g:130:2: VAR ( ident_list type ( SEMICOLON )+ )+
            {
            	VAR64=(IToken)Match(input,VAR,FOLLOW_VAR_in_variables_definition944); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_VAR.Add(VAR64);

            	// PascalGrammar.g:130:6: ( ident_list type ( SEMICOLON )+ )+
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
            			    // PascalGrammar.g:130:7: ident_list type ( SEMICOLON )+
            			    {
            			    	PushFollow(FOLLOW_ident_list_in_variables_definition947);
            			    	ident_list65 = ident_list();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_ident_list.Add(ident_list65.Tree);
            			    	PushFollow(FOLLOW_type_in_variables_definition949);
            			    	type66 = type();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_type.Add(type66.Tree);
            			    	// PascalGrammar.g:130:23: ( SEMICOLON )+
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
            			    			    	SEMICOLON67=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_variables_definition951); if (state.failed) return retval; 
            			    			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON67);


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
            	// elements:          ident_list, type, VAR
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 130:36: -> ^( VAR ( ^( type ident_list ) )+ )
            	{
            	    // PascalGrammar.g:130:39: ^( VAR ( ^( type ident_list ) )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_1);

            	    if ( !(stream_ident_list.HasNext() || stream_type.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_ident_list.HasNext() || stream_type.HasNext() )
            	    {
            	        // PascalGrammar.g:130:45: ^( type ident_list )
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
    // PascalGrammar.g:133:1: params_definition : ( ident_list type ) -> ^( type ident_list ) ;
    public PascalGrammarParser.params_definition_return params_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.params_definition_return retval = new PascalGrammarParser.params_definition_return();
        retval.Start = input.LT(1);
        int params_definition_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.ident_list_return ident_list68 = default(PascalGrammarParser.ident_list_return);

        PascalGrammarParser.type_return type69 = default(PascalGrammarParser.type_return);


        RewriteRuleSubtreeStream stream_ident_list = new RewriteRuleSubtreeStream(adaptor,"rule ident_list");
        RewriteRuleSubtreeStream stream_type = new RewriteRuleSubtreeStream(adaptor,"rule type");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:134:2: ( ( ident_list type ) -> ^( type ident_list ) )
            // PascalGrammar.g:135:2: ( ident_list type )
            {
            	// PascalGrammar.g:135:2: ( ident_list type )
            	// PascalGrammar.g:135:3: ident_list type
            	{
            		PushFollow(FOLLOW_ident_list_in_params_definition982);
            		ident_list68 = ident_list();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_ident_list.Add(ident_list68.Tree);
            		PushFollow(FOLLOW_type_in_params_definition984);
            		type69 = type();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( (state.backtracking==0) ) stream_type.Add(type69.Tree);

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
            	// 135:20: -> ^( type ident_list )
            	{
            	    // PascalGrammar.g:135:23: ^( type ident_list )
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
    // PascalGrammar.g:138:1: method_definition : ( ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) | ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) );
    public PascalGrammarParser.method_definition_return method_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.method_definition_return retval = new PascalGrammarParser.method_definition_return();
        retval.Start = input.LT(1);
        int method_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken PROCEDURE70 = null;
        IToken IDENT71 = null;
        IToken char_literal72 = null;
        IToken char_literal74 = null;
        IToken char_literal76 = null;
        IToken SEMICOLON77 = null;
        IToken BLOCKOPEN80 = null;
        IToken BLOCKEND82 = null;
        IToken FUNCTION83 = null;
        IToken IDENT84 = null;
        IToken char_literal85 = null;
        IToken char_literal87 = null;
        IToken char_literal89 = null;
        IToken SEMICOLON91 = null;
        IToken BLOCKOPEN94 = null;
        IToken BLOCKEND96 = null;
        PascalGrammarParser.params_definition_return params_definition73 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.params_definition_return params_definition75 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.methods_definition_return methods_definition78 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition79 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.expr_list_return expr_list81 = default(PascalGrammarParser.expr_list_return);

        PascalGrammarParser.params_definition_return params_definition86 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.params_definition_return params_definition88 = default(PascalGrammarParser.params_definition_return);

        PascalGrammarParser.type_return type90 = default(PascalGrammarParser.type_return);

        PascalGrammarParser.methods_definition_return methods_definition92 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition93 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.expr_list_return expr_list95 = default(PascalGrammarParser.expr_list_return);


        object PROCEDURE70_tree=null;
        object IDENT71_tree=null;
        object char_literal72_tree=null;
        object char_literal74_tree=null;
        object char_literal76_tree=null;
        object SEMICOLON77_tree=null;
        object BLOCKOPEN80_tree=null;
        object BLOCKEND82_tree=null;
        object FUNCTION83_tree=null;
        object IDENT84_tree=null;
        object char_literal85_tree=null;
        object char_literal87_tree=null;
        object char_literal89_tree=null;
        object SEMICOLON91_tree=null;
        object BLOCKOPEN94_tree=null;
        object BLOCKEND96_tree=null;
        RewriteRuleTokenStream stream_FUNCTION = new RewriteRuleTokenStream(adaptor,"token FUNCTION");
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_PROCEDURE = new RewriteRuleTokenStream(adaptor,"token PROCEDURE");
        RewriteRuleTokenStream stream_BLOCKEND = new RewriteRuleTokenStream(adaptor,"token BLOCKEND");
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");
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
            // PascalGrammar.g:139:2: ( ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) | ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND ) -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) ) )
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
                    // PascalGrammar.g:140:2: ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    {
                    	// PascalGrammar.g:140:2: ( PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    	// PascalGrammar.g:140:3: PROCEDURE IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND
                    	{
                    		PROCEDURE70=(IToken)Match(input,PROCEDURE,FOLLOW_PROCEDURE_in_method_definition1008); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_PROCEDURE.Add(PROCEDURE70);

                    		IDENT71=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_method_definition1010); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT71);

                    		// PascalGrammar.g:140:19: ( '(' ( params_definition ( ';' params_definition )* )? ')' )?
                    		int alt18 = 2;
                    		int LA18_0 = input.LA(1);

                    		if ( (LA18_0 == 36) )
                    		{
                    		    alt18 = 1;
                    		}
                    		switch (alt18) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:140:20: '(' ( params_definition ( ';' params_definition )* )? ')'
                    		        {
                    		        	char_literal72=(IToken)Match(input,36,FOLLOW_36_in_method_definition1013); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_36.Add(char_literal72);

                    		        	// PascalGrammar.g:140:24: ( params_definition ( ';' params_definition )* )?
                    		        	int alt17 = 2;
                    		        	int LA17_0 = input.LA(1);

                    		        	if ( (LA17_0 == IDENT) )
                    		        	{
                    		        	    alt17 = 1;
                    		        	}
                    		        	switch (alt17) 
                    		        	{
                    		        	    case 1 :
                    		        	        // PascalGrammar.g:140:25: params_definition ( ';' params_definition )*
                    		        	        {
                    		        	        	PushFollow(FOLLOW_params_definition_in_method_definition1016);
                    		        	        	params_definition73 = params_definition();
                    		        	        	state.followingStackPointer--;
                    		        	        	if (state.failed) return retval;
                    		        	        	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition73.Tree);
                    		        	        	// PascalGrammar.g:140:43: ( ';' params_definition )*
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
                    		        	        			    // PascalGrammar.g:140:44: ';' params_definition
                    		        	        			    {
                    		        	        			    	char_literal74=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1019); if (state.failed) return retval; 
                    		        	        			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(char_literal74);

                    		        	        			    	PushFollow(FOLLOW_params_definition_in_method_definition1021);
                    		        	        			    	params_definition75 = params_definition();
                    		        	        			    	state.followingStackPointer--;
                    		        	        			    	if (state.failed) return retval;
                    		        	        			    	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition75.Tree);

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

                    		        	char_literal76=(IToken)Match(input,37,FOLLOW_37_in_method_definition1027); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_37.Add(char_literal76);


                    		        }
                    		        break;

                    		}

                    		SEMICOLON77=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1031); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON77);

                    		// PascalGrammar.g:140:86: ( methods_definition )?
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
                    		        	PushFollow(FOLLOW_methods_definition_in_method_definition1033);
                    		        	methods_definition78 = methods_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition78.Tree);

                    		        }
                    		        break;

                    		}

                    		// PascalGrammar.g:141:2: ( variables_definition )?
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
                    		        	PushFollow(FOLLOW_variables_definition_in_method_definition1038);
                    		        	variables_definition79 = variables_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition79.Tree);

                    		        }
                    		        break;

                    		}

                    		BLOCKOPEN80=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_method_definition1041); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN80);

                    		PushFollow(FOLLOW_expr_list_in_method_definition1043);
                    		expr_list81 = expr_list();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list81.Tree);
                    		BLOCKEND82=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_method_definition1045); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND82);


                    	}



                    	// AST REWRITE
                    	// elements:          expr_list, PROCEDURE, variables_definition, methods_definition, params_definition
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 142:2: -> ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	{
                    	    // PascalGrammar.g:142:5: ^( PROCEDURE[$IDENT.text] ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new ProcedureAstNode(PROCEDURE, ((IDENT71 != null) ? IDENT71.Text : null)), root_1);

                    	    // PascalGrammar.g:142:48: ( ^( PARAMS ( params_definition )* ) )?
                    	    if ( stream_params_definition.HasNext() )
                    	    {
                    	        // PascalGrammar.g:142:48: ^( PARAMS ( params_definition )* )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

                    	        // PascalGrammar.g:142:57: ( params_definition )*
                    	        while ( stream_params_definition.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_2, stream_params_definition.NextTree());

                    	        }
                    	        stream_params_definition.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_params_definition.Reset();
                    	    // PascalGrammar.g:142:78: ( methods_definition )?
                    	    if ( stream_methods_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

                    	    }
                    	    stream_methods_definition.Reset();
                    	    // PascalGrammar.g:142:98: ( variables_definition )?
                    	    if ( stream_variables_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

                    	    }
                    	    stream_variables_definition.Reset();
                    	    // PascalGrammar.g:142:120: ^( BLOCK expr_list )
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
                    // PascalGrammar.g:144:2: ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    {
                    	// PascalGrammar.g:144:2: ( FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND )
                    	// PascalGrammar.g:144:3: FUNCTION IDENT ( '(' ( params_definition ( ';' params_definition )* )? ')' )? type SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN expr_list BLOCKEND
                    	{
                    		FUNCTION83=(IToken)Match(input,FUNCTION,FOLLOW_FUNCTION_in_method_definition1085); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_FUNCTION.Add(FUNCTION83);

                    		IDENT84=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_method_definition1087); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT84);

                    		// PascalGrammar.g:144:18: ( '(' ( params_definition ( ';' params_definition )* )? ')' )?
                    		int alt23 = 2;
                    		int LA23_0 = input.LA(1);

                    		if ( (LA23_0 == 36) )
                    		{
                    		    alt23 = 1;
                    		}
                    		switch (alt23) 
                    		{
                    		    case 1 :
                    		        // PascalGrammar.g:144:19: '(' ( params_definition ( ';' params_definition )* )? ')'
                    		        {
                    		        	char_literal85=(IToken)Match(input,36,FOLLOW_36_in_method_definition1090); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_36.Add(char_literal85);

                    		        	// PascalGrammar.g:144:23: ( params_definition ( ';' params_definition )* )?
                    		        	int alt22 = 2;
                    		        	int LA22_0 = input.LA(1);

                    		        	if ( (LA22_0 == IDENT) )
                    		        	{
                    		        	    alt22 = 1;
                    		        	}
                    		        	switch (alt22) 
                    		        	{
                    		        	    case 1 :
                    		        	        // PascalGrammar.g:144:24: params_definition ( ';' params_definition )*
                    		        	        {
                    		        	        	PushFollow(FOLLOW_params_definition_in_method_definition1093);
                    		        	        	params_definition86 = params_definition();
                    		        	        	state.followingStackPointer--;
                    		        	        	if (state.failed) return retval;
                    		        	        	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition86.Tree);
                    		        	        	// PascalGrammar.g:144:42: ( ';' params_definition )*
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
                    		        	        			    // PascalGrammar.g:144:43: ';' params_definition
                    		        	        			    {
                    		        	        			    	char_literal87=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1096); if (state.failed) return retval; 
                    		        	        			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(char_literal87);

                    		        	        			    	PushFollow(FOLLOW_params_definition_in_method_definition1098);
                    		        	        			    	params_definition88 = params_definition();
                    		        	        			    	state.followingStackPointer--;
                    		        	        			    	if (state.failed) return retval;
                    		        	        			    	if ( (state.backtracking==0) ) stream_params_definition.Add(params_definition88.Tree);

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

                    		        	char_literal89=(IToken)Match(input,37,FOLLOW_37_in_method_definition1104); if (state.failed) return retval; 
                    		        	if ( (state.backtracking==0) ) stream_37.Add(char_literal89);


                    		        }
                    		        break;

                    		}

                    		PushFollow(FOLLOW_type_in_method_definition1108);
                    		type90 = type();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_type.Add(type90.Tree);
                    		SEMICOLON91=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_method_definition1110); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON91);

                    		// PascalGrammar.g:144:90: ( methods_definition )?
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
                    		        	PushFollow(FOLLOW_methods_definition_in_method_definition1112);
                    		        	methods_definition92 = methods_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition92.Tree);

                    		        }
                    		        break;

                    		}

                    		// PascalGrammar.g:145:2: ( variables_definition )?
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
                    		        	PushFollow(FOLLOW_variables_definition_in_method_definition1117);
                    		        	variables_definition93 = variables_definition();
                    		        	state.followingStackPointer--;
                    		        	if (state.failed) return retval;
                    		        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition93.Tree);

                    		        }
                    		        break;

                    		}

                    		BLOCKOPEN94=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_method_definition1120); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN94);

                    		PushFollow(FOLLOW_expr_list_in_method_definition1122);
                    		expr_list95 = expr_list();
                    		state.followingStackPointer--;
                    		if (state.failed) return retval;
                    		if ( (state.backtracking==0) ) stream_expr_list.Add(expr_list95.Tree);
                    		BLOCKEND96=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_method_definition1124); if (state.failed) return retval; 
                    		if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND96);


                    	}



                    	// AST REWRITE
                    	// elements:          type, params_definition, variables_definition, expr_list, FUNCTION, methods_definition
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 146:2: -> ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	{
                    	    // PascalGrammar.g:146:5: ^( FUNCTION[$IDENT.text, \"\"] type ( ^( PARAMS ( params_definition )* ) )? ( methods_definition )? ( variables_definition )? ^( BLOCK expr_list ) )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new FunctionAstNode(FUNCTION, ((IDENT84 != null) ? IDENT84.Text : null), ""), root_1);

                    	    adaptor.AddChild(root_1, stream_type.NextTree());
                    	    // PascalGrammar.g:146:55: ( ^( PARAMS ( params_definition )* ) )?
                    	    if ( stream_params_definition.HasNext() )
                    	    {
                    	        // PascalGrammar.g:146:55: ^( PARAMS ( params_definition )* )
                    	        {
                    	        object root_2 = (object)adaptor.GetNilNode();
                    	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

                    	        // PascalGrammar.g:146:64: ( params_definition )*
                    	        while ( stream_params_definition.HasNext() )
                    	        {
                    	            adaptor.AddChild(root_2, stream_params_definition.NextTree());

                    	        }
                    	        stream_params_definition.Reset();

                    	        adaptor.AddChild(root_1, root_2);
                    	        }

                    	    }
                    	    stream_params_definition.Reset();
                    	    // PascalGrammar.g:146:85: ( methods_definition )?
                    	    if ( stream_methods_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

                    	    }
                    	    stream_methods_definition.Reset();
                    	    // PascalGrammar.g:146:105: ( variables_definition )?
                    	    if ( stream_variables_definition.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_variables_definition.NextTree());

                    	    }
                    	    stream_variables_definition.Reset();
                    	    // PascalGrammar.g:146:127: ^( BLOCK expr_list )
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
    // PascalGrammar.g:149:1: methods_definition : method_definition ( SEMICOLON method_definition )* ( SEMICOLON )* -> ^( METHODS ( method_definition )* ) ;
    public PascalGrammarParser.methods_definition_return methods_definition() // throws RecognitionException [1]
    {   
        PascalGrammarParser.methods_definition_return retval = new PascalGrammarParser.methods_definition_return();
        retval.Start = input.LT(1);
        int methods_definition_StartIndex = input.Index();
        object root_0 = null;

        IToken SEMICOLON98 = null;
        IToken SEMICOLON100 = null;
        PascalGrammarParser.method_definition_return method_definition97 = default(PascalGrammarParser.method_definition_return);

        PascalGrammarParser.method_definition_return method_definition99 = default(PascalGrammarParser.method_definition_return);


        object SEMICOLON98_tree=null;
        object SEMICOLON100_tree=null;
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleSubtreeStream stream_method_definition = new RewriteRuleSubtreeStream(adaptor,"rule method_definition");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:150:2: ( method_definition ( SEMICOLON method_definition )* ( SEMICOLON )* -> ^( METHODS ( method_definition )* ) )
            // PascalGrammar.g:151:2: method_definition ( SEMICOLON method_definition )* ( SEMICOLON )*
            {
            	PushFollow(FOLLOW_method_definition_in_methods_definition1173);
            	method_definition97 = method_definition();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_method_definition.Add(method_definition97.Tree);
            	// PascalGrammar.g:151:20: ( SEMICOLON method_definition )*
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
            			    // PascalGrammar.g:151:21: SEMICOLON method_definition
            			    {
            			    	SEMICOLON98=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_methods_definition1176); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON98);

            			    	PushFollow(FOLLOW_method_definition_in_methods_definition1178);
            			    	method_definition99 = method_definition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_method_definition.Add(method_definition99.Tree);

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements

            	// PascalGrammar.g:151:51: ( SEMICOLON )*
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
            			    	SEMICOLON100=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_methods_definition1182); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON100);


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
            	// 151:62: -> ^( METHODS ( method_definition )* )
            	{
            	    // PascalGrammar.g:151:65: ^( METHODS ( method_definition )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METHODS, "METHODS"), root_1);

            	    // PascalGrammar.g:151:75: ( method_definition )*
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
    // PascalGrammar.g:154:1: program : PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.' -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body ) ;
    public PascalGrammarParser.program_return program() // throws RecognitionException [1]
    {   
        PascalGrammarParser.program_return retval = new PascalGrammarParser.program_return();
        retval.Start = input.LT(1);
        int program_StartIndex = input.Index();
        object root_0 = null;

        IToken PROGRAM101 = null;
        IToken IDENT102 = null;
        IToken SEMICOLON103 = null;
        IToken BLOCKOPEN106 = null;
        IToken BLOCKEND108 = null;
        IToken char_literal109 = null;
        PascalGrammarParser.methods_definition_return methods_definition104 = default(PascalGrammarParser.methods_definition_return);

        PascalGrammarParser.variables_definition_return variables_definition105 = default(PascalGrammarParser.variables_definition_return);

        PascalGrammarParser.program_body_return program_body107 = default(PascalGrammarParser.program_body_return);


        object PROGRAM101_tree=null;
        object IDENT102_tree=null;
        object SEMICOLON103_tree=null;
        object BLOCKOPEN106_tree=null;
        object BLOCKEND108_tree=null;
        object char_literal109_tree=null;
        RewriteRuleTokenStream stream_BLOCKOPEN = new RewriteRuleTokenStream(adaptor,"token BLOCKOPEN");
        RewriteRuleTokenStream stream_IDENT = new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_PROGRAM = new RewriteRuleTokenStream(adaptor,"token PROGRAM");
        RewriteRuleTokenStream stream_SEMICOLON = new RewriteRuleTokenStream(adaptor,"token SEMICOLON");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
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
            // PascalGrammar.g:155:2: ( PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.' -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body ) )
            // PascalGrammar.g:156:2: PROGRAM IDENT SEMICOLON ( methods_definition )? ( variables_definition )? BLOCKOPEN program_body BLOCKEND '.'
            {
            	PROGRAM101=(IToken)Match(input,PROGRAM,FOLLOW_PROGRAM_in_program1209); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_PROGRAM.Add(PROGRAM101);

            	IDENT102=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_program1211); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_IDENT.Add(IDENT102);

            	SEMICOLON103=(IToken)Match(input,SEMICOLON,FOLLOW_SEMICOLON_in_program1213); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_SEMICOLON.Add(SEMICOLON103);

            	// PascalGrammar.g:156:26: ( methods_definition )?
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
            	        	PushFollow(FOLLOW_methods_definition_in_program1215);
            	        	methods_definition104 = methods_definition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_methods_definition.Add(methods_definition104.Tree);

            	        }
            	        break;

            	}

            	// PascalGrammar.g:156:46: ( variables_definition )?
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
            	        	PushFollow(FOLLOW_variables_definition_in_program1218);
            	        	variables_definition105 = variables_definition();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_variables_definition.Add(variables_definition105.Tree);

            	        }
            	        break;

            	}

            	BLOCKOPEN106=(IToken)Match(input,BLOCKOPEN,FOLLOW_BLOCKOPEN_in_program1222); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCKOPEN.Add(BLOCKOPEN106);

            	PushFollow(FOLLOW_program_body_in_program1224);
            	program_body107 = program_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_program_body.Add(program_body107.Tree);
            	BLOCKEND108=(IToken)Match(input,BLOCKEND,FOLLOW_BLOCKEND_in_program1226); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BLOCKEND.Add(BLOCKEND108);

            	char_literal109=(IToken)Match(input,40,FOLLOW_40_in_program1228); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal109);



            	// AST REWRITE
            	// elements:          variables_definition, methods_definition, program_body, PROGRAM
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 157:3: -> ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body )
            	{
            	    // PascalGrammar.g:157:6: ^( PROGRAM[$IDENT.text] ( methods_definition )? ( variables_definition )? program_body )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ProgAstNode(PROGRAM, ((IDENT102 != null) ? IDENT102.Text : null)), root_1);

            	    // PascalGrammar.g:157:42: ( methods_definition )?
            	    if ( stream_methods_definition.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_methods_definition.NextTree());

            	    }
            	    stream_methods_definition.Reset();
            	    // PascalGrammar.g:157:62: ( variables_definition )?
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
    // PascalGrammar.g:160:1: result : program ;
    public PascalGrammarParser.result_return result() // throws RecognitionException [1]
    {   
        PascalGrammarParser.result_return retval = new PascalGrammarParser.result_return();
        retval.Start = input.LT(1);
        int result_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.program_return program110 = default(PascalGrammarParser.program_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:161:2: ( program )
            // PascalGrammar.g:162:2: program
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_program_in_result1266);
            	program110 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program110.Tree);

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
    // PascalGrammar.g:165:1: execute : result ;
    public PascalGrammarParser.execute_return execute() // throws RecognitionException [1]
    {   
        PascalGrammarParser.execute_return retval = new PascalGrammarParser.execute_return();
        retval.Start = input.LT(1);
        int execute_StartIndex = input.Index();
        object root_0 = null;

        PascalGrammarParser.result_return result111 = default(PascalGrammarParser.result_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // PascalGrammar.g:166:2: ( result )
            // PascalGrammar.g:167:2: result
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_result_in_execute1284);
            	result111 = result();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result111.Tree);

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

    // $ANTLR start "synpred17_PascalGrammar"
    public void synpred17_PascalGrammar_fragment() {
        // PascalGrammar.g:103:28: ( ELSE expr )
        // PascalGrammar.g:103:28: ELSE expr
        {
        	Match(input,ELSE,FOLLOW_ELSE_in_synpred17_PascalGrammar770); if (state.failed) return ;
        	PushFollow(FOLLOW_expr_in_synpred17_PascalGrammar773);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_PascalGrammar"

    // Delegated rules

   	public bool synpred17_PascalGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred17_PascalGrammar_fragment(); // can never throw exception
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
            get { return "()* loopback of 111:15: ( ( ';' )+ expr )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_36_in_group530 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_term_in_group533 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_group535 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_group541 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_group554 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_group559 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_mult576 = new BitSet(new ulong[]{0x0000000300800002UL});
    public static readonly BitSet FOLLOW_set_in_mult580 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_group_in_mult595 = new BitSet(new ulong[]{0x0000000300800002UL});
    public static readonly BitSet FOLLOW_mult_in_add607 = new BitSet(new ulong[]{0x00000000C3000002UL});
    public static readonly BitSet FOLLOW_set_in_add612 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_mult_in_add631 = new BitSet(new ulong[]{0x00000000C3000002UL});
    public static readonly BitSet FOLLOW_add_in_compare644 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_COMPARE_in_compare648 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_add_in_compare651 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_compare_in_term660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_arg_list669 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_38_in_arg_list672 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_term_in_arg_list675 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_func_call691 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_36_in_func_call694 = new BitSet(new ulong[]{0x000000300C000000UL});
    public static readonly BitSet FOLLOW_arg_list_in_func_call696 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_func_call698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr726 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr728 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_term_in_expr731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_call_in_expr737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_expr742 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_expr744 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_expr746 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_expr759 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr762 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_THEN_in_expr764 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr767 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_ELSE_in_expr770 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr773 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr780 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_expr783 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr785 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_add_in_expr788 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_TO_in_expr790 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_add_in_expr793 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_DO_in_expr795 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr798 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr803 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr806 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_DO_in_expr808 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr811 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DO_in_expr816 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr819 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr821 = new BitSet(new ulong[]{0x000000100C000000UL});
    public static readonly BitSet FOLLOW_compare_in_expr824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list842 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr_list847 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list852 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_expr_list857 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_expr_list863 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_expr_list_in_program_body880 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident_list902 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_38_in_ident_list905 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident_list908 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_39_in_type923 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_type925 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_in_variables_definition944 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_ident_list_in_variables_definition947 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_type_in_variables_definition949 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_variables_definition951 = new BitSet(new ulong[]{0x0000000004000402UL});
    public static readonly BitSet FOLLOW_ident_list_in_params_definition982 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_type_in_params_definition984 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PROCEDURE_in_method_definition1008 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_method_definition1010 = new BitSet(new ulong[]{0x0000001000000400UL});
    public static readonly BitSet FOLLOW_36_in_method_definition1013 = new BitSet(new ulong[]{0x0000002004000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1016 = new BitSet(new ulong[]{0x0000002000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1019 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1021 = new BitSet(new ulong[]{0x0000002000000400UL});
    public static readonly BitSet FOLLOW_37_in_method_definition1027 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1031 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_method_definition1033 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_method_definition1038 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_method_definition1041 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_method_definition1043 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_method_definition1045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNCTION_in_method_definition1085 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_method_definition1087 = new BitSet(new ulong[]{0x0000009000000000UL});
    public static readonly BitSet FOLLOW_36_in_method_definition1090 = new BitSet(new ulong[]{0x0000002004000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1093 = new BitSet(new ulong[]{0x0000002000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1096 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_params_definition_in_method_definition1098 = new BitSet(new ulong[]{0x0000002000000400UL});
    public static readonly BitSet FOLLOW_37_in_method_definition1104 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_type_in_method_definition1108 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_method_definition1110 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_method_definition1112 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_method_definition1117 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_method_definition1120 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_list_in_method_definition1122 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_method_definition1124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_method_definition_in_methods_definition1173 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_methods_definition1176 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_method_definition_in_methods_definition1178 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_methods_definition1182 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_PROGRAM_in_program1209 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_IDENT_in_program1211 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_SEMICOLON_in_program1213 = new BitSet(new ulong[]{0x0000000000006820UL});
    public static readonly BitSet FOLLOW_methods_definition_in_program1215 = new BitSet(new ulong[]{0x0000000000000820UL});
    public static readonly BitSet FOLLOW_variables_definition_in_program1218 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_BLOCKOPEN_in_program1222 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_program_body_in_program1224 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_BLOCKEND_in_program1226 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_program1228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_result1266 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_result_in_execute1284 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_synpred17_PascalGrammar770 = new BitSet(new ulong[]{0x0000000004690C00UL});
    public static readonly BitSet FOLLOW_expr_in_synpred17_PascalGrammar773 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}