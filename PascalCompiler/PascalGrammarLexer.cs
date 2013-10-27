// $ANTLR 3.2 Sep 23, 2009 12:02:23 PascalGrammar.g 2013-10-27 19:17:34

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  PascalCompiler 
{
public partial class PascalGrammarLexer : Lexer {
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
    public const int FUNC_CALL = 15;
    public const int IF = 16;
    public const int BLOCKOPEN = 11;
    public const int WS = 30;
    public const int METHODS = 8;
    public const int THEN = 17;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int STRING_CONST = 9;
    public const int BLOCKEND = 12;
    public const int BLOCK = 6;
    public const int OR = 24;
    public const int ASSIGN = 35;
    public const int COMPARE = 36;
    public const int IDENT = 26;
    public const int PROGRAM = 4;
    public const int VAR = 5;
    public const int DIV = 34;
    public const int COMMENT = 28;
    public const int STRING = 29;
    public const int PARAMS = 7;
    public const int ADD = 31;

    // delegates
    // delegators

    public PascalGrammarLexer() 
    {
		InitializeCyclicDFAs();
    }
    public PascalGrammarLexer(ICharStream input)
		: this(input, null) {
    }
    public PascalGrammarLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "PascalGrammar.g";} 
    }

    // $ANTLR start "PROGRAM"
    public void mPROGRAM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PROGRAM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:9:9: ( 'program' )
            // PascalGrammar.g:9:11: 'program'
            {
            	Match("program"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PROGRAM"

    // $ANTLR start "VAR"
    public void mVAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:10:5: ( 'var' )
            // PascalGrammar.g:10:7: 'var'
            {
            	Match("var"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VAR"

    // $ANTLR start "SEMICOLON"
    public void mSEMICOLON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SEMICOLON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:11:11: ( ';' )
            // PascalGrammar.g:11:13: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SEMICOLON"

    // $ANTLR start "BLOCKOPEN"
    public void mBLOCKOPEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BLOCKOPEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:12:11: ( 'begin' )
            // PascalGrammar.g:12:13: 'begin'
            {
            	Match("begin"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BLOCKOPEN"

    // $ANTLR start "BLOCKEND"
    public void mBLOCKEND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BLOCKEND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:13:10: ( 'end' )
            // PascalGrammar.g:13:12: 'end'
            {
            	Match("end"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BLOCKEND"

    // $ANTLR start "FUNCTION"
    public void mFUNCTION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FUNCTION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:14:10: ( 'function' )
            // PascalGrammar.g:14:12: 'function'
            {
            	Match("function"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FUNCTION"

    // $ANTLR start "PROCEDURE"
    public void mPROCEDURE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PROCEDURE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:15:11: ( 'procedure' )
            // PascalGrammar.g:15:13: 'procedure'
            {
            	Match("procedure"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PROCEDURE"

    // $ANTLR start "IF"
    public void mIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:16:4: ( 'if' )
            // PascalGrammar.g:16:6: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IF"

    // $ANTLR start "THEN"
    public void mTHEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = THEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:17:6: ( 'then' )
            // PascalGrammar.g:17:8: 'then'
            {
            	Match("then"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "THEN"

    // $ANTLR start "ELSE"
    public void mELSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:18:6: ( 'else' )
            // PascalGrammar.g:18:8: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSE"

    // $ANTLR start "FOR"
    public void mFOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:19:5: ( 'for' )
            // PascalGrammar.g:19:7: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FOR"

    // $ANTLR start "TO"
    public void mTO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:20:4: ( 'to' )
            // PascalGrammar.g:20:6: 'to'
            {
            	Match("to"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TO"

    // $ANTLR start "DO"
    public void mDO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:21:4: ( 'do' )
            // PascalGrammar.g:21:6: 'do'
            {
            	Match("do"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DO"

    // $ANTLR start "WHILE"
    public void mWHILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:22:7: ( 'while' )
            // PascalGrammar.g:22:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHILE"

    // $ANTLR start "AND"
    public void mAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:23:5: ( 'and' )
            // PascalGrammar.g:23:7: 'and'
            {
            	Match("and"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "OR"
    public void mOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:24:4: ( 'or' )
            // PascalGrammar.g:24:6: 'or'
            {
            	Match("or"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OR"

    // $ANTLR start "XOR"
    public void mXOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = XOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:25:5: ( 'xor' )
            // PascalGrammar.g:25:7: 'xor'
            {
            	Match("xor"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "XOR"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:26:7: ( '(' )
            // PascalGrammar.g:26:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:27:7: ( ')' )
            // PascalGrammar.g:27:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:28:7: ( ',' )
            // PascalGrammar.g:28:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:29:7: ( ':' )
            // PascalGrammar.g:29:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:30:7: ( '.' )
            // PascalGrammar.g:30:9: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:49:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // PascalGrammar.g:50:2: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// PascalGrammar.g:50:26: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // PascalGrammar.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENT"

    // $ANTLR start "NUMBER"
    public void mNUMBER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUMBER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:53:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? | '.' ( '0' .. '9' )+ )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
            {
                alt6 = 1;
            }
            else if ( (LA6_0 == '.') )
            {
                alt6 = 2;
            }
            else 
            {
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("", 6, 0, input);

                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // PascalGrammar.g:54:5: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
                    {
                    	// PascalGrammar.g:54:5: ( '0' .. '9' )+
                    	int cnt2 = 0;
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // PascalGrammar.g:54:6: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt2 >= 1 ) goto loop2;
                    		            EarlyExitException eee2 =
                    		                new EarlyExitException(2, input);
                    		            throw eee2;
                    	    }
                    	    cnt2++;
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements

                    	// PascalGrammar.g:54:17: ( '.' ( '0' .. '9' )+ )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == '.') )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // PascalGrammar.g:54:18: '.' ( '0' .. '9' )+
                    	        {
                    	        	Match('.'); 
                    	        	// PascalGrammar.g:54:22: ( '0' .. '9' )+
                    	        	int cnt3 = 0;
                    	        	do 
                    	        	{
                    	        	    int alt3 = 2;
                    	        	    int LA3_0 = input.LA(1);

                    	        	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    	        	    {
                    	        	        alt3 = 1;
                    	        	    }


                    	        	    switch (alt3) 
                    	        		{
                    	        			case 1 :
                    	        			    // PascalGrammar.g:54:23: '0' .. '9'
                    	        			    {
                    	        			    	MatchRange('0','9'); 

                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    if ( cnt3 >= 1 ) goto loop3;
                    	        		            EarlyExitException eee3 =
                    	        		                new EarlyExitException(3, input);
                    	        		            throw eee3;
                    	        	    }
                    	        	    cnt3++;
                    	        	} while (true);

                    	        	loop3:
                    	        		;	// Stops C# compiler whining that label 'loop3' has no statements


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // PascalGrammar.g:55:9: '.' ( '0' .. '9' )+
                    {
                    	Match('.'); 
                    	// PascalGrammar.g:55:13: ( '0' .. '9' )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // PascalGrammar.g:55:14: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUMBER"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:59:2: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '{' ( options {greedy=false; } : . )* '}' )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == '/') )
            {
                alt10 = 1;
            }
            else if ( (LA10_0 == '{') )
            {
                alt10 = 2;
            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // PascalGrammar.g:60:2: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// PascalGrammar.g:60:7: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt7 = 2;
                    	    int LA7_0 = input.LA(1);

                    	    if ( ((LA7_0 >= '\u0000' && LA7_0 <= '\t') || (LA7_0 >= '\u000B' && LA7_0 <= '\f') || (LA7_0 >= '\u000E' && LA7_0 <= '\uFFFF')) )
                    	    {
                    	        alt7 = 1;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // PascalGrammar.g:60:7: ~ ( '\\n' | '\\r' )
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop7;
                    	    }
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whining that label 'loop7' has no statements

                    	// PascalGrammar.g:60:21: ( '\\r' )?
                    	int alt8 = 2;
                    	int LA8_0 = input.LA(1);

                    	if ( (LA8_0 == '\r') )
                    	{
                    	    alt8 = 1;
                    	}
                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // PascalGrammar.g:60:21: '\\r'
                    	        {
                    	        	Match('\r'); 

                    	        }
                    	        break;

                    	}

                    	Match('\n'); 
                    	_channel=HIDDEN;

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:61:7: '{' ( options {greedy=false; } : . )* '}'
                    {
                    	Match('{'); 
                    	// PascalGrammar.g:61:11: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt9 = 2;
                    	    int LA9_0 = input.LA(1);

                    	    if ( (LA9_0 == '}') )
                    	    {
                    	        alt9 = 2;
                    	    }
                    	    else if ( ((LA9_0 >= '\u0000' && LA9_0 <= '|') || (LA9_0 >= '~' && LA9_0 <= '\uFFFF')) )
                    	    {
                    	        alt9 = 1;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // PascalGrammar.g:61:39: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop9;
                    	    }
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whining that label 'loop9' has no statements

                    	Match('}'); 
                    	_channel=HIDDEN;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:64:8: ( '\"' ( ( '\\\\\"' ) | (~ '\"' ) )* '\"' )
            // PascalGrammar.g:65:2: '\"' ( ( '\\\\\"' ) | (~ '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// PascalGrammar.g:65:6: ( ( '\\\\\"' ) | (~ '\"' ) )*
            	do 
            	{
            	    int alt11 = 3;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == '\\') )
            	    {
            	        int LA11_2 = input.LA(2);

            	        if ( (LA11_2 == '\"') )
            	        {
            	            int LA11_4 = input.LA(3);

            	            if ( ((LA11_4 >= '\u0000' && LA11_4 <= '\uFFFF')) )
            	            {
            	                alt11 = 1;
            	            }

            	            else 
            	            {
            	                alt11 = 2;
            	            }

            	        }
            	        else if ( ((LA11_2 >= '\u0000' && LA11_2 <= '!') || (LA11_2 >= '#' && LA11_2 <= '\uFFFF')) )
            	        {
            	            alt11 = 2;
            	        }


            	    }
            	    else if ( ((LA11_0 >= '\u0000' && LA11_0 <= '!') || (LA11_0 >= '#' && LA11_0 <= '[') || (LA11_0 >= ']' && LA11_0 <= '\uFFFF')) )
            	    {
            	        alt11 = 2;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // PascalGrammar.g:65:7: ( '\\\\\"' )
            			    {
            			    	// PascalGrammar.g:65:7: ( '\\\\\"' )
            			    	// PascalGrammar.g:65:8: '\\\\\"'
            			    	{
            			    		Match("\\\""); 


            			    	}


            			    }
            			    break;
            			case 2 :
            			    // PascalGrammar.g:65:17: (~ '\"' )
            			    {
            			    	// PascalGrammar.g:65:17: (~ '\"' )
            			    	// PascalGrammar.g:65:18: ~ '\"'
            			    	{
            			    		if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF') ) 
            			    		{
            			    		    input.Consume();

            			    		}
            			    		else 
            			    		{
            			    		    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    		    Recover(mse);
            			    		    throw mse;}


            			    	}


            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:68:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
            // PascalGrammar.g:69:5: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            {
            	// PascalGrammar.g:69:5: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            	int cnt12 = 0;
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= '\t' && LA12_0 <= '\n') || (LA12_0 >= '\f' && LA12_0 <= '\r') || LA12_0 == ' ') )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // PascalGrammar.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt12 >= 1 ) goto loop12;
            		            EarlyExitException eee12 =
            		                new EarlyExitException(12, input);
            		            throw eee12;
            	    }
            	    cnt12++;
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "ADD"
    public void mADD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ADD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:72:4: ( '+' )
            // PascalGrammar.g:72:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ADD"

    // $ANTLR start "SUB"
    public void mSUB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SUB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:73:4: ( '-' )
            // PascalGrammar.g:73:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SUB"

    // $ANTLR start "MUL"
    public void mMUL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MUL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:74:4: ( '*' )
            // PascalGrammar.g:74:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MUL"

    // $ANTLR start "DIV"
    public void mDIV() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIV;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:75:4: ( '/' )
            // PascalGrammar.g:75:9: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "ASSIGN"
    public void mASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:76:7: ( ':=' )
            // PascalGrammar.g:76:9: ':='
            {
            	Match(":="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGN"

    // $ANTLR start "COMPARE"
    public void mCOMPARE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMPARE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:77:8: ( '>' | '>=' | '<' | '<=' | '=' | '!=' )
            int alt13 = 6;
            switch ( input.LA(1) ) 
            {
            case '>':
            	{
                int LA13_1 = input.LA(2);

                if ( (LA13_1 == '=') )
                {
                    alt13 = 2;
                }
                else 
                {
                    alt13 = 1;}
                }
                break;
            case '<':
            	{
                int LA13_2 = input.LA(2);

                if ( (LA13_2 == '=') )
                {
                    alt13 = 4;
                }
                else 
                {
                    alt13 = 3;}
                }
                break;
            case '=':
            	{
                alt13 = 5;
                }
                break;
            case '!':
            	{
                alt13 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d13s0 =
            	        new NoViableAltException("", 13, 0, input);

            	    throw nvae_d13s0;
            }

            switch (alt13) 
            {
                case 1 :
                    // PascalGrammar.g:77:10: '>'
                    {
                    	Match('>'); 

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:77:16: '>='
                    {
                    	Match(">="); 


                    }
                    break;
                case 3 :
                    // PascalGrammar.g:77:23: '<'
                    {
                    	Match('<'); 

                    }
                    break;
                case 4 :
                    // PascalGrammar.g:77:29: '<='
                    {
                    	Match("<="); 


                    }
                    break;
                case 5 :
                    // PascalGrammar.g:77:36: '='
                    {
                    	Match('='); 

                    }
                    break;
                case 6 :
                    // PascalGrammar.g:77:42: '!='
                    {
                    	Match("!="); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMPARE"

    override public void mTokens() // throws RecognitionException 
    {
        // PascalGrammar.g:1:8: ( PROGRAM | VAR | SEMICOLON | BLOCKOPEN | BLOCKEND | FUNCTION | PROCEDURE | IF | THEN | ELSE | FOR | TO | DO | WHILE | AND | OR | XOR | T__37 | T__38 | T__39 | T__40 | T__41 | IDENT | NUMBER | COMMENT | STRING | WS | ADD | SUB | MUL | DIV | ASSIGN | COMPARE )
        int alt14 = 33;
        alt14 = dfa14.Predict(input);
        switch (alt14) 
        {
            case 1 :
                // PascalGrammar.g:1:10: PROGRAM
                {
                	mPROGRAM(); 

                }
                break;
            case 2 :
                // PascalGrammar.g:1:18: VAR
                {
                	mVAR(); 

                }
                break;
            case 3 :
                // PascalGrammar.g:1:22: SEMICOLON
                {
                	mSEMICOLON(); 

                }
                break;
            case 4 :
                // PascalGrammar.g:1:32: BLOCKOPEN
                {
                	mBLOCKOPEN(); 

                }
                break;
            case 5 :
                // PascalGrammar.g:1:42: BLOCKEND
                {
                	mBLOCKEND(); 

                }
                break;
            case 6 :
                // PascalGrammar.g:1:51: FUNCTION
                {
                	mFUNCTION(); 

                }
                break;
            case 7 :
                // PascalGrammar.g:1:60: PROCEDURE
                {
                	mPROCEDURE(); 

                }
                break;
            case 8 :
                // PascalGrammar.g:1:70: IF
                {
                	mIF(); 

                }
                break;
            case 9 :
                // PascalGrammar.g:1:73: THEN
                {
                	mTHEN(); 

                }
                break;
            case 10 :
                // PascalGrammar.g:1:78: ELSE
                {
                	mELSE(); 

                }
                break;
            case 11 :
                // PascalGrammar.g:1:83: FOR
                {
                	mFOR(); 

                }
                break;
            case 12 :
                // PascalGrammar.g:1:87: TO
                {
                	mTO(); 

                }
                break;
            case 13 :
                // PascalGrammar.g:1:90: DO
                {
                	mDO(); 

                }
                break;
            case 14 :
                // PascalGrammar.g:1:93: WHILE
                {
                	mWHILE(); 

                }
                break;
            case 15 :
                // PascalGrammar.g:1:99: AND
                {
                	mAND(); 

                }
                break;
            case 16 :
                // PascalGrammar.g:1:103: OR
                {
                	mOR(); 

                }
                break;
            case 17 :
                // PascalGrammar.g:1:106: XOR
                {
                	mXOR(); 

                }
                break;
            case 18 :
                // PascalGrammar.g:1:110: T__37
                {
                	mT__37(); 

                }
                break;
            case 19 :
                // PascalGrammar.g:1:116: T__38
                {
                	mT__38(); 

                }
                break;
            case 20 :
                // PascalGrammar.g:1:122: T__39
                {
                	mT__39(); 

                }
                break;
            case 21 :
                // PascalGrammar.g:1:128: T__40
                {
                	mT__40(); 

                }
                break;
            case 22 :
                // PascalGrammar.g:1:134: T__41
                {
                	mT__41(); 

                }
                break;
            case 23 :
                // PascalGrammar.g:1:140: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 24 :
                // PascalGrammar.g:1:146: NUMBER
                {
                	mNUMBER(); 

                }
                break;
            case 25 :
                // PascalGrammar.g:1:153: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 26 :
                // PascalGrammar.g:1:161: STRING
                {
                	mSTRING(); 

                }
                break;
            case 27 :
                // PascalGrammar.g:1:168: WS
                {
                	mWS(); 

                }
                break;
            case 28 :
                // PascalGrammar.g:1:171: ADD
                {
                	mADD(); 

                }
                break;
            case 29 :
                // PascalGrammar.g:1:175: SUB
                {
                	mSUB(); 

                }
                break;
            case 30 :
                // PascalGrammar.g:1:179: MUL
                {
                	mMUL(); 

                }
                break;
            case 31 :
                // PascalGrammar.g:1:183: DIV
                {
                	mDIV(); 

                }
                break;
            case 32 :
                // PascalGrammar.g:1:187: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 33 :
                // PascalGrammar.g:1:194: COMPARE
                {
                	mCOMPARE(); 

                }
                break;

        }

    }


    protected DFA14 dfa14;
	private void InitializeCyclicDFAs()
	{
	    this.dfa14 = new DFA14(this);
	}

    const string DFA14_eotS =
        "\x01\uffff\x02\x13\x01\uffff\x0a\x13\x03\uffff\x01\x2d\x01\x2e"+
        "\x02\uffff\x01\x2f\x07\uffff\x07\x13\x01\x37\x01\x13\x01\x39\x01"+
        "\x3a\x02\x13\x01\x3d\x01\x13\x04\uffff\x01\x13\x01\x41\x01\x13\x01"+
        "\x43\x02\x13\x01\x46\x01\uffff\x01\x13\x02\uffff\x01\x13\x01\x49"+
        "\x01\uffff\x01\x4a\x02\x13\x01\uffff\x01\x13\x01\uffff\x01\x4e\x01"+
        "\x13\x01\uffff\x01\x50\x01\x13\x02\uffff\x02\x13\x01\x54\x01\uffff"+
        "\x01\x13\x01\uffff\x01\x56\x02\x13\x01\uffff\x01\x13\x01\uffff\x01"+
        "\x5a\x02\x13\x01\uffff\x01\x13\x01\x5e\x01\x5f\x02\uffff";
    const string DFA14_eofS =
        "\x60\uffff";
    const string DFA14_minS =
        "\x01\x09\x01\x72\x01\x61\x01\uffff\x01\x65\x01\x6c\x01\x6f\x01"+
        "\x66\x01\x68\x01\x6f\x01\x68\x01\x6e\x01\x72\x01\x6f\x03\uffff\x01"+
        "\x3d\x01\x30\x02\uffff\x01\x2f\x07\uffff\x01\x6f\x01\x72\x01\x67"+
        "\x01\x64\x01\x73\x01\x6e\x01\x72\x01\x30\x01\x65\x02\x30\x01\x69"+
        "\x01\x64\x01\x30\x01\x72\x04\uffff\x01\x63\x01\x30\x01\x69\x01\x30"+
        "\x01\x65\x01\x63\x01\x30\x01\uffff\x01\x6e\x02\uffff\x01\x6c\x01"+
        "\x30\x01\uffff\x01\x30\x01\x72\x01\x65\x01\uffff\x01\x6e\x01\uffff"+
        "\x01\x30\x01\x74\x01\uffff\x01\x30\x01\x65\x02\uffff\x01\x61\x01"+
        "\x64\x01\x30\x01\uffff\x01\x69\x01\uffff\x01\x30\x01\x6d\x01\x75"+
        "\x01\uffff\x01\x6f\x01\uffff\x01\x30\x01\x72\x01\x6e\x01\uffff\x01"+
        "\x65\x02\x30\x02\uffff";
    const string DFA14_maxS =
        "\x01\x7b\x01\x72\x01\x61\x01\uffff\x01\x65\x01\x6e\x01\x75\x01"+
        "\x66\x02\x6f\x01\x68\x01\x6e\x01\x72\x01\x6f\x03\uffff\x01\x3d\x01"+
        "\x39\x02\uffff\x01\x2f\x07\uffff\x01\x6f\x01\x72\x01\x67\x01\x64"+
        "\x01\x73\x01\x6e\x01\x72\x01\x7a\x01\x65\x02\x7a\x01\x69\x01\x64"+
        "\x01\x7a\x01\x72\x04\uffff\x01\x67\x01\x7a\x01\x69\x01\x7a\x01\x65"+
        "\x01\x63\x01\x7a\x01\uffff\x01\x6e\x02\uffff\x01\x6c\x01\x7a\x01"+
        "\uffff\x01\x7a\x01\x72\x01\x65\x01\uffff\x01\x6e\x01\uffff\x01\x7a"+
        "\x01\x74\x01\uffff\x01\x7a\x01\x65\x02\uffff\x01\x61\x01\x64\x01"+
        "\x7a\x01\uffff\x01\x69\x01\uffff\x01\x7a\x01\x6d\x01\x75\x01\uffff"+
        "\x01\x6f\x01\uffff\x01\x7a\x01\x72\x01\x6e\x01\uffff\x01\x65\x02"+
        "\x7a\x02\uffff";
    const string DFA14_acceptS =
        "\x03\uffff\x01\x03\x0a\uffff\x01\x12\x01\x13\x01\x14\x02\uffff"+
        "\x01\x17\x01\x18\x01\uffff\x01\x19\x01\x1a\x01\x1b\x01\x1c\x01\x1d"+
        "\x01\x1e\x01\x21\x0f\uffff\x01\x20\x01\x15\x01\x16\x01\x1f\x07\uffff"+
        "\x01\x08\x01\uffff\x01\x0c\x01\x0d\x02\uffff\x01\x10\x03\uffff\x01"+
        "\x02\x01\uffff\x01\x05\x02\uffff\x01\x0b\x02\uffff\x01\x0f\x01\x11"+
        "\x03\uffff\x01\x0a\x01\uffff\x01\x09\x03\uffff\x01\x04\x01\uffff"+
        "\x01\x0e\x03\uffff\x01\x01\x03\uffff\x01\x06\x01\x07";
    const string DFA14_specialS =
        "\x60\uffff}>";
    static readonly string[] DFA14_transitionS = {
            "\x02\x18\x01\uffff\x02\x18\x12\uffff\x01\x18\x01\x1c\x01\x17"+
            "\x05\uffff\x01\x0e\x01\x0f\x01\x1b\x01\x19\x01\x10\x01\x1a\x01"+
            "\x12\x01\x15\x0a\x14\x01\x11\x01\x03\x03\x1c\x02\uffff\x1a\x13"+
            "\x04\uffff\x01\x13\x01\uffff\x01\x0b\x01\x04\x01\x13\x01\x09"+
            "\x01\x05\x01\x06\x02\x13\x01\x07\x05\x13\x01\x0c\x01\x01\x03"+
            "\x13\x01\x08\x01\x13\x01\x02\x01\x0a\x01\x0d\x02\x13\x01\x16",
            "\x01\x1d",
            "\x01\x1e",
            "",
            "\x01\x1f",
            "\x01\x21\x01\uffff\x01\x20",
            "\x01\x23\x05\uffff\x01\x22",
            "\x01\x24",
            "\x01\x25\x06\uffff\x01\x26",
            "\x01\x27",
            "\x01\x28",
            "\x01\x29",
            "\x01\x2a",
            "\x01\x2b",
            "",
            "",
            "",
            "\x01\x2c",
            "\x0a\x14",
            "",
            "",
            "\x01\x16",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x30",
            "\x01\x31",
            "\x01\x32",
            "\x01\x33",
            "\x01\x34",
            "\x01\x35",
            "\x01\x36",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x38",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x3b",
            "\x01\x3c",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x3e",
            "",
            "",
            "",
            "",
            "\x01\x40\x03\uffff\x01\x3f",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x42",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x44",
            "\x01\x45",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "",
            "\x01\x47",
            "",
            "",
            "\x01\x48",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x4b",
            "\x01\x4c",
            "",
            "\x01\x4d",
            "",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x4f",
            "",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x51",
            "",
            "",
            "\x01\x52",
            "\x01\x53",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "",
            "\x01\x55",
            "",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x57",
            "\x01\x58",
            "",
            "\x01\x59",
            "",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x5b",
            "\x01\x5c",
            "",
            "\x01\x5d",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "",
            ""
    };

    static readonly short[] DFA14_eot = DFA.UnpackEncodedString(DFA14_eotS);
    static readonly short[] DFA14_eof = DFA.UnpackEncodedString(DFA14_eofS);
    static readonly char[] DFA14_min = DFA.UnpackEncodedStringToUnsignedChars(DFA14_minS);
    static readonly char[] DFA14_max = DFA.UnpackEncodedStringToUnsignedChars(DFA14_maxS);
    static readonly short[] DFA14_accept = DFA.UnpackEncodedString(DFA14_acceptS);
    static readonly short[] DFA14_special = DFA.UnpackEncodedString(DFA14_specialS);
    static readonly short[][] DFA14_transition = DFA.UnpackEncodedStringArray(DFA14_transitionS);

    protected class DFA14 : DFA
    {
        public DFA14(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 14;
            this.eot = DFA14_eot;
            this.eof = DFA14_eof;
            this.min = DFA14_min;
            this.max = DFA14_max;
            this.accept = DFA14_accept;
            this.special = DFA14_special;
            this.transition = DFA14_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( PROGRAM | VAR | SEMICOLON | BLOCKOPEN | BLOCKEND | FUNCTION | PROCEDURE | IF | THEN | ELSE | FOR | TO | DO | WHILE | AND | OR | XOR | T__37 | T__38 | T__39 | T__40 | T__41 | IDENT | NUMBER | COMMENT | STRING | WS | ADD | SUB | MUL | DIV | ASSIGN | COMPARE );"; }
        }

    }

 
    
}
}