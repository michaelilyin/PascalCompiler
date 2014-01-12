// $ANTLR 3.2 Sep 23, 2009 12:02:23 PascalGrammar.g 2014-01-10 21:51:44

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
    public const int WHILE = 23;
    public const int FOR = 20;
    public const int DO = 22;
    public const int SUB = 35;
    public const int NOT = 27;
    public const int AND = 24;
    public const int EOF = -1;
    public const int IF = 17;
    public const int FUNC_CALL = 15;
    public const int BOOLEAN = 28;
    public const int THEN = 18;
    public const int METHODS = 8;
    public const int STRING_CONST = 9;
    public const int COMPARE = 39;
    public const int IDENT = 29;
    public const int VAR = 5;
    public const int COMMENT = 31;
    public const int PARAMS = 7;
    public const int ADD = 34;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int XOR = 26;
    public const int T__44 = 44;
    public const int CONVERT = 16;
    public const int TO = 21;
    public const int ELSE = 19;
    public const int NUMBER = 30;
    public const int SEMICOLON = 10;
    public const int MUL = 36;
    public const int PROCEDURE = 14;
    public const int BLOCKOPEN = 11;
    public const int WS = 33;
    public const int BLOCK = 6;
    public const int BLOCKEND = 12;
    public const int OR = 25;
    public const int ASSIGN = 38;
    public const int PROGRAM = 4;
    public const int DIV = 37;
    public const int STRING = 32;

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

    // $ANTLR start "NOT"
    public void mNOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:26:5: ( 'not' )
            // PascalGrammar.g:26:7: 'not'
            {
            	Match("not"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOT"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:27:7: ( '(' )
            // PascalGrammar.g:27:9: '('
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
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:28:7: ( ')' )
            // PascalGrammar.g:28:9: ')'
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
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:29:7: ( ',' )
            // PascalGrammar.g:29:9: ','
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
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:30:7: ( ':' )
            // PascalGrammar.g:30:9: ':'
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
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:31:7: ( '.' )
            // PascalGrammar.g:31:9: '.'
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
    // $ANTLR end "T__44"

    // $ANTLR start "BOOLEAN"
    public void mBOOLEAN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BOOLEAN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // PascalGrammar.g:51:9: ( ( 'true' ) | ( 'false' ) )
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
                    // PascalGrammar.g:52:2: ( 'true' )
                    {
                    	// PascalGrammar.g:52:2: ( 'true' )
                    	// PascalGrammar.g:52:3: 'true'
                    	{
                    		Match("true"); 


                    	}


                    }
                    break;
                case 2 :
                    // PascalGrammar.g:52:11: ( 'false' )
                    {
                    	// PascalGrammar.g:52:11: ( 'false' )
                    	// PascalGrammar.g:52:12: 'false'
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
            // PascalGrammar.g:55:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )* )
            // PascalGrammar.g:56:2: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
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

            	// PascalGrammar.g:56:26: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' )*
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
            // PascalGrammar.g:59:7: ( ( '-' )? ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? | '.' ( '0' .. '9' )+ ) )
            // PascalGrammar.g:60:5: ( '-' )? ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? | '.' ( '0' .. '9' )+ )
            {
            	// PascalGrammar.g:60:5: ( '-' )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == '-') )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:60:5: '-'
            	        {
            	        	Match('-'); 

            	        }
            	        break;

            	}

            	// PascalGrammar.g:60:9: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? | '.' ( '0' .. '9' )+ )
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
            	{
            	    alt8 = 1;
            	}
            	else if ( (LA8_0 == '.') )
            	{
            	    alt8 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // PascalGrammar.g:60:10: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
            	        {
            	        	// PascalGrammar.g:60:10: ( '0' .. '9' )+
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
            	        			    // PascalGrammar.g:60:11: '0' .. '9'
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

            	        	// PascalGrammar.g:60:22: ( '.' ( '0' .. '9' )+ )?
            	        	int alt6 = 2;
            	        	int LA6_0 = input.LA(1);

            	        	if ( (LA6_0 == '.') )
            	        	{
            	        	    alt6 = 1;
            	        	}
            	        	switch (alt6) 
            	        	{
            	        	    case 1 :
            	        	        // PascalGrammar.g:60:23: '.' ( '0' .. '9' )+
            	        	        {
            	        	        	Match('.'); 
            	        	        	// PascalGrammar.g:60:27: ( '0' .. '9' )+
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
            	        	        			    // PascalGrammar.g:60:28: '0' .. '9'
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


            	        }
            	        break;
            	    case 2 :
            	        // PascalGrammar.g:61:9: '.' ( '0' .. '9' )+
            	        {
            	        	Match('.'); 
            	        	// PascalGrammar.g:61:13: ( '0' .. '9' )+
            	        	int cnt7 = 0;
            	        	do 
            	        	{
            	        	    int alt7 = 2;
            	        	    int LA7_0 = input.LA(1);

            	        	    if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
            	        	    {
            	        	        alt7 = 1;
            	        	    }


            	        	    switch (alt7) 
            	        		{
            	        			case 1 :
            	        			    // PascalGrammar.g:61:14: '0' .. '9'
            	        			    {
            	        			    	MatchRange('0','9'); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt7 >= 1 ) goto loop7;
            	        		            EarlyExitException eee7 =
            	        		                new EarlyExitException(7, input);
            	        		            throw eee7;
            	        	    }
            	        	    cnt7++;
            	        	} while (true);

            	        	loop7:
            	        		;	// Stops C# compiler whining that label 'loop7' has no statements


            	        }
            	        break;

            	}


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
            // PascalGrammar.g:65:2: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '{' ( options {greedy=false; } : . )* '}' )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == '/') )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == '{') )
            {
                alt12 = 2;
            }
            else 
            {
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // PascalGrammar.g:66:2: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// PascalGrammar.g:66:7: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt9 = 2;
                    	    int LA9_0 = input.LA(1);

                    	    if ( ((LA9_0 >= '\u0000' && LA9_0 <= '\t') || (LA9_0 >= '\u000B' && LA9_0 <= '\f') || (LA9_0 >= '\u000E' && LA9_0 <= '\uFFFF')) )
                    	    {
                    	        alt9 = 1;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // PascalGrammar.g:66:7: ~ ( '\\n' | '\\r' )
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
                    			    goto loop9;
                    	    }
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whining that label 'loop9' has no statements

                    	// PascalGrammar.g:66:21: ( '\\r' )?
                    	int alt10 = 2;
                    	int LA10_0 = input.LA(1);

                    	if ( (LA10_0 == '\r') )
                    	{
                    	    alt10 = 1;
                    	}
                    	switch (alt10) 
                    	{
                    	    case 1 :
                    	        // PascalGrammar.g:66:21: '\\r'
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
                    // PascalGrammar.g:67:7: '{' ( options {greedy=false; } : . )* '}'
                    {
                    	Match('{'); 
                    	// PascalGrammar.g:67:11: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt11 = 2;
                    	    int LA11_0 = input.LA(1);

                    	    if ( (LA11_0 == '}') )
                    	    {
                    	        alt11 = 2;
                    	    }
                    	    else if ( ((LA11_0 >= '\u0000' && LA11_0 <= '|') || (LA11_0 >= '~' && LA11_0 <= '\uFFFF')) )
                    	    {
                    	        alt11 = 1;
                    	    }


                    	    switch (alt11) 
                    		{
                    			case 1 :
                    			    // PascalGrammar.g:67:39: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop11;
                    	    }
                    	} while (true);

                    	loop11:
                    		;	// Stops C# compiler whining that label 'loop11' has no statements

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
            // PascalGrammar.g:70:8: ( '\"' ( ( '\\\\\"' ) | (~ '\"' ) )* '\"' )
            // PascalGrammar.g:71:2: '\"' ( ( '\\\\\"' ) | (~ '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// PascalGrammar.g:71:6: ( ( '\\\\\"' ) | (~ '\"' ) )*
            	do 
            	{
            	    int alt13 = 3;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == '\\') )
            	    {
            	        int LA13_2 = input.LA(2);

            	        if ( (LA13_2 == '\"') )
            	        {
            	            int LA13_4 = input.LA(3);

            	            if ( ((LA13_4 >= '\u0000' && LA13_4 <= '\uFFFF')) )
            	            {
            	                alt13 = 1;
            	            }

            	            else 
            	            {
            	                alt13 = 2;
            	            }

            	        }
            	        else if ( ((LA13_2 >= '\u0000' && LA13_2 <= '!') || (LA13_2 >= '#' && LA13_2 <= '\uFFFF')) )
            	        {
            	            alt13 = 2;
            	        }


            	    }
            	    else if ( ((LA13_0 >= '\u0000' && LA13_0 <= '!') || (LA13_0 >= '#' && LA13_0 <= '[') || (LA13_0 >= ']' && LA13_0 <= '\uFFFF')) )
            	    {
            	        alt13 = 2;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // PascalGrammar.g:71:7: ( '\\\\\"' )
            			    {
            			    	// PascalGrammar.g:71:7: ( '\\\\\"' )
            			    	// PascalGrammar.g:71:8: '\\\\\"'
            			    	{
            			    		Match("\\\""); 


            			    	}


            			    }
            			    break;
            			case 2 :
            			    // PascalGrammar.g:71:17: (~ '\"' )
            			    {
            			    	// PascalGrammar.g:71:17: (~ '\"' )
            			    	// PascalGrammar.g:71:18: ~ '\"'
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
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

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
            // PascalGrammar.g:74:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
            // PascalGrammar.g:75:5: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            {
            	// PascalGrammar.g:75:5: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            	int cnt14 = 0;
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= '\t' && LA14_0 <= '\n') || (LA14_0 >= '\f' && LA14_0 <= '\r') || LA14_0 == ' ') )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
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
            			    if ( cnt14 >= 1 ) goto loop14;
            		            EarlyExitException eee14 =
            		                new EarlyExitException(14, input);
            		            throw eee14;
            	    }
            	    cnt14++;
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

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
            // PascalGrammar.g:78:4: ( '+' )
            // PascalGrammar.g:78:9: '+'
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
            // PascalGrammar.g:79:4: ( '-' )
            // PascalGrammar.g:79:9: '-'
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
            // PascalGrammar.g:80:4: ( '*' )
            // PascalGrammar.g:80:9: '*'
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
            // PascalGrammar.g:81:4: ( '/' )
            // PascalGrammar.g:81:9: '/'
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
            // PascalGrammar.g:82:7: ( ':=' )
            // PascalGrammar.g:82:9: ':='
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
            // PascalGrammar.g:83:8: ( '>' | '>=' | '<' | '<=' | '=' | '!=' )
            int alt15 = 6;
            switch ( input.LA(1) ) 
            {
            case '>':
            	{
                int LA15_1 = input.LA(2);

                if ( (LA15_1 == '=') )
                {
                    alt15 = 2;
                }
                else 
                {
                    alt15 = 1;}
                }
                break;
            case '<':
            	{
                int LA15_2 = input.LA(2);

                if ( (LA15_2 == '=') )
                {
                    alt15 = 4;
                }
                else 
                {
                    alt15 = 3;}
                }
                break;
            case '=':
            	{
                alt15 = 5;
                }
                break;
            case '!':
            	{
                alt15 = 6;
                }
                break;
            	default:
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            }

            switch (alt15) 
            {
                case 1 :
                    // PascalGrammar.g:83:10: '>'
                    {
                    	Match('>'); 

                    }
                    break;
                case 2 :
                    // PascalGrammar.g:83:16: '>='
                    {
                    	Match(">="); 


                    }
                    break;
                case 3 :
                    // PascalGrammar.g:83:23: '<'
                    {
                    	Match('<'); 

                    }
                    break;
                case 4 :
                    // PascalGrammar.g:83:29: '<='
                    {
                    	Match("<="); 


                    }
                    break;
                case 5 :
                    // PascalGrammar.g:83:36: '='
                    {
                    	Match('='); 

                    }
                    break;
                case 6 :
                    // PascalGrammar.g:83:42: '!='
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
        // PascalGrammar.g:1:8: ( PROGRAM | VAR | SEMICOLON | BLOCKOPEN | BLOCKEND | FUNCTION | PROCEDURE | IF | THEN | ELSE | FOR | TO | DO | WHILE | AND | OR | XOR | NOT | T__40 | T__41 | T__42 | T__43 | T__44 | BOOLEAN | IDENT | NUMBER | COMMENT | STRING | WS | ADD | SUB | MUL | DIV | ASSIGN | COMPARE )
        int alt16 = 35;
        alt16 = dfa16.Predict(input);
        switch (alt16) 
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
                // PascalGrammar.g:1:110: NOT
                {
                	mNOT(); 

                }
                break;
            case 19 :
                // PascalGrammar.g:1:114: T__40
                {
                	mT__40(); 

                }
                break;
            case 20 :
                // PascalGrammar.g:1:120: T__41
                {
                	mT__41(); 

                }
                break;
            case 21 :
                // PascalGrammar.g:1:126: T__42
                {
                	mT__42(); 

                }
                break;
            case 22 :
                // PascalGrammar.g:1:132: T__43
                {
                	mT__43(); 

                }
                break;
            case 23 :
                // PascalGrammar.g:1:138: T__44
                {
                	mT__44(); 

                }
                break;
            case 24 :
                // PascalGrammar.g:1:144: BOOLEAN
                {
                	mBOOLEAN(); 

                }
                break;
            case 25 :
                // PascalGrammar.g:1:152: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 26 :
                // PascalGrammar.g:1:158: NUMBER
                {
                	mNUMBER(); 

                }
                break;
            case 27 :
                // PascalGrammar.g:1:165: COMMENT
                {
                	mCOMMENT(); 

                }
                break;
            case 28 :
                // PascalGrammar.g:1:173: STRING
                {
                	mSTRING(); 

                }
                break;
            case 29 :
                // PascalGrammar.g:1:180: WS
                {
                	mWS(); 

                }
                break;
            case 30 :
                // PascalGrammar.g:1:183: ADD
                {
                	mADD(); 

                }
                break;
            case 31 :
                // PascalGrammar.g:1:187: SUB
                {
                	mSUB(); 

                }
                break;
            case 32 :
                // PascalGrammar.g:1:191: MUL
                {
                	mMUL(); 

                }
                break;
            case 33 :
                // PascalGrammar.g:1:195: DIV
                {
                	mDIV(); 

                }
                break;
            case 34 :
                // PascalGrammar.g:1:199: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 35 :
                // PascalGrammar.g:1:206: COMPARE
                {
                	mCOMPARE(); 

                }
                break;

        }

    }


    protected DFA16 dfa16;
	private void InitializeCyclicDFAs()
	{
	    this.dfa16 = new DFA16(this);
	}

    const string DFA16_eotS =
        "\x01\uffff\x02\x14\x01\uffff\x0b\x14\x03\uffff\x01\x31\x01\x32"+
        "\x01\uffff\x01\x33\x01\uffff\x01\x34\x06\uffff\x08\x14\x01\x3d\x01"+
        "\x14\x01\x3f\x01\x14\x01\x41\x02\x14\x01\x44\x02\x14\x05\uffff\x01"+
        "\x14\x01\x49\x01\x14\x01\x4b\x02\x14\x01\x4e\x01\x14\x01\uffff\x01"+
        "\x14\x01\uffff\x01\x14\x01\uffff\x01\x14\x01\x53\x01\uffff\x01\x54"+
        "\x01\x55\x02\x14\x01\uffff\x01\x14\x01\uffff\x01\x59\x01\x14\x01"+
        "\uffff\x01\x14\x01\x5c\x01\x5d\x01\x14\x03\uffff\x02\x14\x01\x61"+
        "\x01\uffff\x01\x14\x01\x5d\x02\uffff\x01\x63\x02\x14\x01\uffff\x01"+
        "\x14\x01\uffff\x01\x67\x02\x14\x01\uffff\x01\x14\x01\x6b\x01\x6c"+
        "\x02\uffff";
    const string DFA16_eofS =
        "\x6d\uffff";
    const string DFA16_minS =
        "\x01\x09\x01\x72\x01\x61\x01\uffff\x01\x65\x01\x6c\x01\x61\x01"+
        "\x66\x01\x68\x01\x6f\x01\x68\x01\x6e\x01\x72\x02\x6f\x03\uffff\x01"+
        "\x3d\x01\x30\x01\uffff\x01\x2e\x01\uffff\x01\x2f\x06\uffff\x01\x6f"+
        "\x01\x72\x01\x67\x01\x64\x01\x73\x01\x6e\x01\x72\x01\x6c\x01\x30"+
        "\x01\x65\x01\x30\x01\x75\x01\x30\x01\x69\x01\x64\x01\x30\x01\x72"+
        "\x01\x74\x05\uffff\x01\x63\x01\x30\x01\x69\x01\x30\x01\x65\x01\x63"+
        "\x01\x30\x01\x73\x01\uffff\x01\x6e\x01\uffff\x01\x65\x01\uffff\x01"+
        "\x6c\x01\x30\x01\uffff\x02\x30\x01\x72\x01\x65\x01\uffff\x01\x6e"+
        "\x01\uffff\x01\x30\x01\x74\x01\uffff\x01\x65\x02\x30\x01\x65\x03"+
        "\uffff\x01\x61\x01\x64\x01\x30\x01\uffff\x01\x69\x01\x30\x02\uffff"+
        "\x01\x30\x01\x6d\x01\x75\x01\uffff\x01\x6f\x01\uffff\x01\x30\x01"+
        "\x72\x01\x6e\x01\uffff\x01\x65\x02\x30\x02\uffff";
    const string DFA16_maxS =
        "\x01\x7b\x01\x72\x01\x61\x01\uffff\x01\x65\x01\x6e\x01\x75\x01"+
        "\x66\x01\x72\x01\x6f\x01\x68\x01\x6e\x01\x72\x02\x6f\x03\uffff\x01"+
        "\x3d\x01\x39\x01\uffff\x01\x39\x01\uffff\x01\x2f\x06\uffff\x01\x6f"+
        "\x01\x72\x01\x67\x01\x64\x01\x73\x01\x6e\x01\x72\x01\x6c\x01\x7a"+
        "\x01\x65\x01\x7a\x01\x75\x01\x7a\x01\x69\x01\x64\x01\x7a\x01\x72"+
        "\x01\x74\x05\uffff\x01\x67\x01\x7a\x01\x69\x01\x7a\x01\x65\x01\x63"+
        "\x01\x7a\x01\x73\x01\uffff\x01\x6e\x01\uffff\x01\x65\x01\uffff\x01"+
        "\x6c\x01\x7a\x01\uffff\x02\x7a\x01\x72\x01\x65\x01\uffff\x01\x6e"+
        "\x01\uffff\x01\x7a\x01\x74\x01\uffff\x01\x65\x02\x7a\x01\x65\x03"+
        "\uffff\x01\x61\x01\x64\x01\x7a\x01\uffff\x01\x69\x01\x7a\x02\uffff"+
        "\x01\x7a\x01\x6d\x01\x75\x01\uffff\x01\x6f\x01\uffff\x01\x7a\x01"+
        "\x72\x01\x6e\x01\uffff\x01\x65\x02\x7a\x02\uffff";
    const string DFA16_acceptS =
        "\x03\uffff\x01\x03\x0b\uffff\x01\x13\x01\x14\x01\x15\x02\uffff"+
        "\x01\x19\x01\uffff\x01\x1a\x01\uffff\x01\x1b\x01\x1c\x01\x1d\x01"+
        "\x1e\x01\x20\x01\x23\x12\uffff\x01\x22\x01\x16\x01\x17\x01\x1f\x01"+
        "\x21\x08\uffff\x01\x08\x01\uffff\x01\x0c\x01\uffff\x01\x0d\x02\uffff"+
        "\x01\x10\x04\uffff\x01\x02\x01\uffff\x01\x05\x02\uffff\x01\x0b\x04"+
        "\uffff\x01\x0f\x01\x11\x01\x12\x03\uffff\x01\x0a\x02\uffff\x01\x09"+
        "\x01\x18\x03\uffff\x01\x04\x01\uffff\x01\x0e\x03\uffff\x01\x01\x03"+
        "\uffff\x01\x06\x01\x07";
    const string DFA16_specialS =
        "\x6d\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x02\x1a\x01\uffff\x02\x1a\x12\uffff\x01\x1a\x01\x1d\x01\x19"+
            "\x05\uffff\x01\x0f\x01\x10\x01\x1c\x01\x1b\x01\x11\x01\x15\x01"+
            "\x13\x01\x17\x0a\x16\x01\x12\x01\x03\x03\x1d\x02\uffff\x1a\x14"+
            "\x04\uffff\x01\x14\x01\uffff\x01\x0b\x01\x04\x01\x14\x01\x09"+
            "\x01\x05\x01\x06\x02\x14\x01\x07\x04\x14\x01\x0e\x01\x0c\x01"+
            "\x01\x03\x14\x01\x08\x01\x14\x01\x02\x01\x0a\x01\x0d\x02\x14"+
            "\x01\x18",
            "\x01\x1e",
            "\x01\x1f",
            "",
            "\x01\x20",
            "\x01\x22\x01\uffff\x01\x21",
            "\x01\x25\x0d\uffff\x01\x24\x05\uffff\x01\x23",
            "\x01\x26",
            "\x01\x27\x06\uffff\x01\x28\x02\uffff\x01\x29",
            "\x01\x2a",
            "\x01\x2b",
            "\x01\x2c",
            "\x01\x2d",
            "\x01\x2e",
            "\x01\x2f",
            "",
            "",
            "",
            "\x01\x30",
            "\x0a\x16",
            "",
            "\x01\x16\x01\uffff\x0a\x16",
            "",
            "\x01\x18",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x35",
            "\x01\x36",
            "\x01\x37",
            "\x01\x38",
            "\x01\x39",
            "\x01\x3a",
            "\x01\x3b",
            "\x01\x3c",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x3e",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x40",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x42",
            "\x01\x43",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x45",
            "\x01\x46",
            "",
            "",
            "",
            "",
            "",
            "\x01\x48\x03\uffff\x01\x47",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x4a",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x4c",
            "\x01\x4d",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x4f",
            "",
            "\x01\x50",
            "",
            "\x01\x51",
            "",
            "\x01\x52",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x56",
            "\x01\x57",
            "",
            "\x01\x58",
            "",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x5a",
            "",
            "\x01\x5b",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x5e",
            "",
            "",
            "",
            "\x01\x5f",
            "\x01\x60",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "",
            "\x01\x62",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "",
            "",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x64",
            "\x01\x65",
            "",
            "\x01\x66",
            "",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x01\x68",
            "\x01\x69",
            "",
            "\x01\x6a",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "\x0a\x14\x07\uffff\x1a\x14\x04\uffff\x01\x14\x01\uffff\x1a"+
            "\x14",
            "",
            ""
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( PROGRAM | VAR | SEMICOLON | BLOCKOPEN | BLOCKEND | FUNCTION | PROCEDURE | IF | THEN | ELSE | FOR | TO | DO | WHILE | AND | OR | XOR | NOT | T__40 | T__41 | T__42 | T__43 | T__44 | BOOLEAN | IDENT | NUMBER | COMMENT | STRING | WS | ADD | SUB | MUL | DIV | ASSIGN | COMPARE );"; }
        }

    }

 
    
}
}