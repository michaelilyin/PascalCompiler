// $ANTLR 3.2 Sep 23, 2009 12:02:23 PascalGrammar.g 2013-10-27 19:40:44

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
    public const int T__42 = 42;
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
    public const int FUNC_CALL = 15;
    public const int IF = 16;
    public const int BLOCKOPEN = 11;
    public const int BOOLEAN = 26;
    public const int WS = 31;
    public const int METHODS = 8;
    public const int THEN = 17;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int STRING_CONST = 9;
    public const int BLOCKEND = 12;
    public const int BLOCK = 6;
    public const int OR = 24;
    public const int ASSIGN = 36;
    public const int COMPARE = 37;
    public const int IDENT = 27;
    public const int PROGRAM = 4;
    public const int VAR = 5;
    public const int DIV = 35;
    public const int COMMENT = 29;
    public const int STRING = 30;
    public const int PARAMS = 7;
    public const int ADD = 32;

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

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
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
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
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
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
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
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
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
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
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
    // $ANTLR end "T__42"

    // $ANTLR start "BOOLEAN"
    public void mBOOLEAN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BOOLEAN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:49:9: ( ( 'true' ) | ( 'false' ) )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == 't') )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == 'f') )
            {
                alt1 = 2;
            }
            else 
            {
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // PascalGrammar.g:50:2: ( 'true' )
                    {
                    	// PascalGrammar.g:50:2: ( 'true' )
                    	// PascalGrammar.g:50:3: 'true'
                    	{
                    		Match("true"); 


                    	}


                    }
                    break;
                case 2 :
                    // PascalGrammar.g:50:11: ( 'false' )
                    {
                    	// PascalGrammar.g:50:11: ( 'false' )
                    	// PascalGrammar.g:50:12: 'false'
                    	{
                    		Match("false"); 


                    	}


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
    // $ANTLR end "BOOLEAN"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:53:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // PascalGrammar.g:54:2: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
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

            	// PascalGrammar.g:54:26: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9') || (LA2_0 >= 'A' && LA2_0 <= 'Z') || LA2_0 == '_' || (LA2_0 >= 'a' && LA2_0 <= 'z')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
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
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


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
            // PascalGrammar.g:57:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? | '.' ( '0' .. '9' )+ )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == '.') )
            {
                alt7 = 2;
            }
            else 
            {
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // PascalGrammar.g:58:5: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
                    {
                    	// PascalGrammar.g:58:5: ( '0' .. '9' )+
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
                    			    // PascalGrammar.g:58:6: '0' .. '9'
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

                    	// PascalGrammar.g:58:17: ( '.' ( '0' .. '9' )+ )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == '.') )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // PascalGrammar.g:58:18: '.' ( '0' .. '9' )+
                    	        {
                    	        	Match('.'); 
                    	        	// PascalGrammar.g:58:22: ( '0' .. '9' )+
                    	        	int cnt4 = 0;
                    	        	do 
                    	        	{
                    	        	    int alt4 = 2;
                    	        	    int LA4_0 = input.LA(1);

                    	        	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	        	    {
                    	        	        alt4 = 1;
                    	        	    }


                    	        	    switch (alt4) 
                    	        		{
                    	        			case 1 :
                    	        			    // PascalGrammar.g:58:23: '0' .. '9'
                    	        			    {
                    	        			    	MatchRange('0','9'); 

                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    if ( cnt4 >= 1 ) goto loop4;
                    	        		            EarlyExitException eee4 =
                    	        		                new EarlyExitException(4, input);
                    	        		            throw eee4;
                    	        	    }
                    	        	    cnt4++;
                    	        	} while (true);

                    	        	loop4:
                    	        		;	// Stops C# compiler whining that label 'loop4' has no statements


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // PascalGrammar.g:59:9: '.' ( '0' .. '9' )+
                    {
                    	Match('.'); 
                    	// PascalGrammar.g:59:13: ( '0' .. '9' )+
                    	int cnt6 = 0;
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // PascalGrammar.g:59:14: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt6 >= 1 ) goto loop6;
                    		            EarlyExitException eee6 =
                    		                new EarlyExitException(6, input);
                    		            throw eee6;
                    	    }
                    	    cnt6++;
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements


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
            // PascalGrammar.g:63:2: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '{' ( options {greedy=false; } : . )* '}' )
            int alt11 = 2;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == '/') )
            {
                alt11 = 1;
            }
            else if ( (LA11_0 == '{') )
            {
                alt11 = 2;
            }
            else 
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // PascalGrammar.g:64:2: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// PascalGrammar.g:64:7: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( ((LA8_0 >= '\u0000' && LA8_0 <= '\t') || (LA8_0 >= '\u000B' && LA8_0 <= '\f') || (LA8_0 >= '\u000E' && LA8_0 <= '\uFFFF')) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // PascalGrammar.g:64:7: ~ ( '\\n' | '\\r' )
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
                    			    goto loop8;
                    	    }
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whining that label 'loop8' has no statements

                    	// PascalGrammar.g:64:21: ( '\\r' )?
                    	int alt9 = 2;
                    	int LA9_0 = input.LA(1);

                    	if ( (LA9_0 == '\r') )
                    	{
                    	    alt9 = 1;
                    	}
                    	switch (alt9) 
                    	{
                    	    case 1 :
                    	        // PascalGrammar.g:64:21: '\\r'
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
                    // PascalGrammar.g:65:7: '{' ( options {greedy=false; } : . )* '}'
                    {
                    	Match('{'); 
                    	// PascalGrammar.g:65:11: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( (LA10_0 == '}') )
                    	    {
                    	        alt10 = 2;
                    	    }
                    	    else if ( ((LA10_0 >= '\u0000' && LA10_0 <= '|') || (LA10_0 >= '~' && LA10_0 <= '\uFFFF')) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // PascalGrammar.g:65:39: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop10;
                    	    }
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whining that label 'loop10' has no statements

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
            // PascalGrammar.g:68:8: ( '\"' ( ( '\\\\\"' ) | (~ '\"' ) )* '\"' )
            // PascalGrammar.g:69:2: '\"' ( ( '\\\\\"' ) | (~ '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// PascalGrammar.g:69:6: ( ( '\\\\\"' ) | (~ '\"' ) )*
            	do 
            	{
            	    int alt12 = 3;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == '\\') )
            	    {
            	        int LA12_2 = input.LA(2);

            	        if ( (LA12_2 == '\"') )
            	        {
            	            int LA12_4 = input.LA(3);

            	            if ( ((LA12_4 >= '\u0000' && LA12_4 <= '\uFFFF')) )
            	            {
            	                alt12 = 1;
            	            }

            	            else 
            	            {
            	                alt12 = 2;
            	            }

            	        }
            	        else if ( ((LA12_2 >= '\u0000' && LA12_2 <= '!') || (LA12_2 >= '#' && LA12_2 <= '\uFFFF')) )
            	        {
            	            alt12 = 2;
            	        }


            	    }
            	    else if ( ((LA12_0 >= '\u0000' && LA12_0 <= '!') || (LA12_0 >= '#' && LA12_0 <= '[') || (LA12_0 >= ']' && LA12_0 <= '\uFFFF')) )
            	    {
            	        alt12 = 2;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // PascalGrammar.g:69:7: ( '\\\\\"' )
            			    {
            			    	// PascalGrammar.g:69:7: ( '\\\\\"' )
            			    	// PascalGrammar.g:69:8: '\\\\\"'
            			    	{
            			    		Match("\\\""); 


            			    	}


            			    }
            			    break;
            			case 2 :
            			    // PascalGrammar.g:69:17: (~ '\"' )
            			    {
            			    	// PascalGrammar.g:69:17: (~ '\"' )
            			    	// PascalGrammar.g:69:18: ~ '\"'
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
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

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
            // PascalGrammar.g:72:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
            // PascalGrammar.g:73:5: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            {
            	// PascalGrammar.g:73:5: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= '\t' && LA13_0 <= '\n') || (LA13_0 >= '\f' && LA13_0 <= '\r') || LA13_0 == ' ') )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
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
            			    if ( cnt13 >= 1 ) goto loop13;
            		            EarlyExitException eee13 =
            		                new EarlyExitException(13, input);
            		            throw eee13;
            	    }
            	    cnt13++;
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

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
            // PascalGrammar.g:76:4: ( '+' )
            // PascalGrammar.g:76:9: '+'
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
            // PascalGrammar.g:77:4: ( '-' )
            // PascalGrammar.g:77:9: '-'
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
            // PascalGrammar.g:78:4: ( '*' )
            // PascalGrammar.g:78:9: '*'
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
            // PascalGrammar.g:79:4: ( '/' )
            // PascalGrammar.g:79:9: '/'
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
            // PascalGrammar.g:80:7: ( ':=' )
            // PascalGrammar.g:80:9: ':='
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
            // PascalGrammar.g:81:8: ( '>' | '>=' | '<' | '<=' | '=' | '!=' )
            int alt14 = 6;
            switch ( input.LA(1) ) 
            {
            case '>':
            	{
                int LA14_1 = input.LA(2);

                if ( (LA14_1 == '=') )
                {
                    alt14 = 2;
                }
                else 
                {
                    alt14 = 1;}
                }
                break;
            case '<':
            	{
                int LA14_2 = input.LA(2);

                if ( (LA14_2 == '=') )
                {
                    alt14 = 4;
                }
                else 
                {
                    alt14 = 3;}
                }
                break;
            case '=':
            	{
                alt14 = 5;
                }
                break;
            case '!':
            	{
                alt14 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            }

            switch (alt14) 
            {
                case 1 :
                    // PascalGrammar.g:81:10: '>'
                    {
                    	Match('>'); 

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:81:16: '>='
                    {
                    	Match(">="); 


                    }
                    break;
                case 3 :
                    // PascalGrammar.g:81:23: '<'
                    {
                    	Match('<'); 

                    }
                    break;
                case 4 :
                    // PascalGrammar.g:81:29: '<='
                    {
                    	Match("<="); 


                    }
                    break;
                case 5 :
                    // PascalGrammar.g:81:36: '='
                    {
                    	Match('='); 

                    }
                    break;
                case 6 :
                    // PascalGrammar.g:81:42: '!='
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
        // PascalGrammar.g:1:8: ( PROGRAM | VAR | SEMICOLON | BLOCKOPEN | BLOCKEND | FUNCTION | PROCEDURE | IF | THEN | ELSE | FOR | TO | DO | WHILE | AND | OR | XOR | T__38 | T__39 | T__40 | T__41 | T__42 | BOOLEAN | IDENT | NUMBER | COMMENT | STRING | WS | ADD | SUB | MUL | DIV | ASSIGN | COMPARE )
        int alt15 = 34;
        alt15 = dfa15.Predict(input);
        switch (alt15) 
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
                // PascalGrammar.g:1:110: T__38
                {
                	mT__38(); 

                }
                break;
            case 19 :
                // PascalGrammar.g:1:116: T__39
                {
                	mT__39(); 

                }
                break;
            case 20 :
                // PascalGrammar.g:1:122: T__40
                {
                	mT__40(); 

                }
                break;
            case 21 :
                // PascalGrammar.g:1:128: T__41
                {
                	mT__41(); 

                }
                break;
            case 22 :
                // PascalGrammar.g:1:134: T__42
                {
                	mT__42(); 

                }
                break;
            case 23 :
                // PascalGrammar.g:1:140: BOOLEAN
                {
                	mBOOLEAN(); 

                }
                break;
            case 24 :
                // PascalGrammar.g:1:148: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 25 :
                // PascalGrammar.g:1:154: NUMBER
                {
                	mNUMBER(); 

                }
                break;
            case 26 :
                // PascalGrammar.g:1:161: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 27 :
                // PascalGrammar.g:1:169: STRING
                {
                	mSTRING(); 

                }
                break;
            case 28 :
                // PascalGrammar.g:1:176: WS
                {
                	mWS(); 

                }
                break;
            case 29 :
                // PascalGrammar.g:1:179: ADD
                {
                	mADD(); 

                }
                break;
            case 30 :
                // PascalGrammar.g:1:183: SUB
                {
                	mSUB(); 

                }
                break;
            case 31 :
                // PascalGrammar.g:1:187: MUL
                {
                	mMUL(); 

                }
                break;
            case 32 :
                // PascalGrammar.g:1:191: DIV
                {
                	mDIV(); 

                }
                break;
            case 33 :
                // PascalGrammar.g:1:195: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 34 :
                // PascalGrammar.g:1:202: COMPARE
                {
                	mCOMPARE(); 

                }
                break;

        }

    }


    protected DFA15 dfa15;
	private void InitializeCyclicDFAs()
	{
	    this.dfa15 = new DFA15(this);
	}

    const string DFA15_eotS =
        "\x01\uffff\x02\x13\x01\uffff\x0a\x13\x03\uffff\x01\x2f\x01\x30"+
        "\x02\uffff\x01\x31\x07\uffff\x08\x13\x01\x3a\x01\x13\x01\x3c\x01"+
        "\x13\x01\x3e\x02\x13\x01\x41\x01\x13\x04\uffff\x01\x13\x01\x45\x01"+
        "\x13\x01\x47\x02\x13\x01\x4a\x01\x13\x01\uffff\x01\x13\x01\uffff"+
        "\x01\x13\x01\uffff\x01\x13\x01\x4f\x01\uffff\x01\x50\x02\x13\x01"+
        "\uffff\x01\x13\x01\uffff\x01\x54\x01\x13\x01\uffff\x01\x13\x01\x57"+
        "\x01\x58\x01\x13\x02\uffff\x02\x13\x01\x5c\x01\uffff\x01\x13\x01"+
        "\x58\x02\uffff\x01\x5e\x02\x13\x01\uffff\x01\x13\x01\uffff\x01\x62"+
        "\x02\x13\x01\uffff\x01\x13\x01\x66\x01\x67\x02\uffff";
    const string DFA15_eofS =
        "\x68\uffff";
    const string DFA15_minS =
        "\x01\x09\x01\x72\x01\x61\x01\uffff\x01\x65\x01\x6c\x01\x61\x01"+
        "\x66\x01\x68\x01\x6f\x01\x68\x01\x6e\x01\x72\x01\x6f\x03\uffff\x01"+
        "\x3d\x01\x30\x02\uffff\x01\x2f\x07\uffff\x01\x6f\x01\x72\x01\x67"+
        "\x01\x64\x01\x73\x01\x6e\x01\x72\x01\x6c\x01\x30\x01\x65\x01\x30"+
        "\x01\x75\x01\x30\x01\x69\x01\x64\x01\x30\x01\x72\x04\uffff\x01\x63"+
        "\x01\x30\x01\x69\x01\x30\x01\x65\x01\x63\x01\x30\x01\x73\x01\uffff"+
        "\x01\x6e\x01\uffff\x01\x65\x01\uffff\x01\x6c\x01\x30\x01\uffff\x01"+
        "\x30\x01\x72\x01\x65\x01\uffff\x01\x6e\x01\uffff\x01\x30\x01\x74"+
        "\x01\uffff\x01\x65\x02\x30\x01\x65\x02\uffff\x01\x61\x01\x64\x01"+
        "\x30\x01\uffff\x01\x69\x01\x30\x02\uffff\x01\x30\x01\x6d\x01\x75"+
        "\x01\uffff\x01\x6f\x01\uffff\x01\x30\x01\x72\x01\x6e\x01\uffff\x01"+
        "\x65\x02\x30\x02\uffff";
    const string DFA15_maxS =
        "\x01\x7b\x01\x72\x01\x61\x01\uffff\x01\x65\x01\x6e\x01\x75\x01"+
        "\x66\x01\x72\x01\x6f\x01\x68\x01\x6e\x01\x72\x01\x6f\x03\uffff\x01"+
        "\x3d\x01\x39\x02\uffff\x01\x2f\x07\uffff\x01\x6f\x01\x72\x01\x67"+
        "\x01\x64\x01\x73\x01\x6e\x01\x72\x01\x6c\x01\x7a\x01\x65\x01\x7a"+
        "\x01\x75\x01\x7a\x01\x69\x01\x64\x01\x7a\x01\x72\x04\uffff\x01\x67"+
        "\x01\x7a\x01\x69\x01\x7a\x01\x65\x01\x63\x01\x7a\x01\x73\x01\uffff"+
        "\x01\x6e\x01\uffff\x01\x65\x01\uffff\x01\x6c\x01\x7a\x01\uffff\x01"+
        "\x7a\x01\x72\x01\x65\x01\uffff\x01\x6e\x01\uffff\x01\x7a\x01\x74"+
        "\x01\uffff\x01\x65\x02\x7a\x01\x65\x02\uffff\x01\x61\x01\x64\x01"+
        "\x7a\x01\uffff\x01\x69\x01\x7a\x02\uffff\x01\x7a\x01\x6d\x01\x75"+
        "\x01\uffff\x01\x6f\x01\uffff\x01\x7a\x01\x72\x01\x6e\x01\uffff\x01"+
        "\x65\x02\x7a\x02\uffff";
    const string DFA15_acceptS =
        "\x03\uffff\x01\x03\x0a\uffff\x01\x12\x01\x13\x01\x14\x02\uffff"+
        "\x01\x18\x01\x19\x01\uffff\x01\x1a\x01\x1b\x01\x1c\x01\x1d\x01\x1e"+
        "\x01\x1f\x01\x22\x11\uffff\x01\x21\x01\x15\x01\x16\x01\x20\x08\uffff"+
        "\x01\x08\x01\uffff\x01\x0c\x01\uffff\x01\x0d\x02\uffff\x01\x10\x03"+
        "\uffff\x01\x02\x01\uffff\x01\x05\x02\uffff\x01\x0b\x04\uffff\x01"+
        "\x0f\x01\x11\x03\uffff\x01\x0a\x02\uffff\x01\x09\x01\x17\x03\uffff"+
        "\x01\x04\x01\uffff\x01\x0e\x03\uffff\x01\x01\x03\uffff\x01\x06\x01"+
        "\x07";
    const string DFA15_specialS =
        "\x68\uffff}>";
    static readonly string[] DFA15_transitionS = {
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
            "\x01\x24\x0d\uffff\x01\x23\x05\uffff\x01\x22",
            "\x01\x25",
            "\x01\x26\x06\uffff\x01\x27\x02\uffff\x01\x28",
            "\x01\x29",
            "\x01\x2a",
            "\x01\x2b",
            "\x01\x2c",
            "\x01\x2d",
            "",
            "",
            "",
            "\x01\x2e",
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
            "\x01\x32",
            "\x01\x33",
            "\x01\x34",
            "\x01\x35",
            "\x01\x36",
            "\x01\x37",
            "\x01\x38",
            "\x01\x39",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x3b",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x3d",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x3f",
            "\x01\x40",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x42",
            "",
            "",
            "",
            "",
            "\x01\x44\x03\uffff\x01\x43",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x46",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x48",
            "\x01\x49",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x4b",
            "",
            "\x01\x4c",
            "",
            "\x01\x4d",
            "",
            "\x01\x4e",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x51",
            "\x01\x52",
            "",
            "\x01\x53",
            "",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x55",
            "",
            "\x01\x56",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x59",
            "",
            "",
            "\x01\x5a",
            "\x01\x5b",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "",
            "\x01\x5d",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "",
            "",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x5f",
            "\x01\x60",
            "",
            "\x01\x61",
            "",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x01\x63",
            "\x01\x64",
            "",
            "\x01\x65",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "\x0a\x13\x07\uffff\x1a\x13\x04\uffff\x01\x13\x01\uffff\x1a"+
            "\x13",
            "",
            ""
    };

    static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
    static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
    static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
    static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
    static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
    static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
    static readonly short[][] DFA15_transition = DFA.UnpackEncodedStringArray(DFA15_transitionS);

    protected class DFA15 : DFA
    {
        public DFA15(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 15;
            this.eot = DFA15_eot;
            this.eof = DFA15_eof;
            this.min = DFA15_min;
            this.max = DFA15_max;
            this.accept = DFA15_accept;
            this.special = DFA15_special;
            this.transition = DFA15_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( PROGRAM | VAR | SEMICOLON | BLOCKOPEN | BLOCKEND | FUNCTION | PROCEDURE | IF | THEN | ELSE | FOR | TO | DO | WHILE | AND | OR | XOR | T__38 | T__39 | T__40 | T__41 | T__42 | BOOLEAN | IDENT | NUMBER | COMMENT | STRING | WS | ADD | SUB | MUL | DIV | ASSIGN | COMPARE );"; }
        }

    }

 
    
}
}