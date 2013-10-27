grammar PascalGrammar;

options {
  language=CSharp2;
  output=AST;
  backtrack=true;
  memoize=true;
}

tokens {
	PROGRAM = 'program';
	VAR = 'var';
	BLOCK;
	PARAMS;
	METHODS;
	STRING_CONST;
	SEMICOLON = ';';
	BLOCKOPEN = 'begin';
	BLOCKEND = 'end';
	FUNCTION = 'function';
	PROCEDURE = 'procedure';
	FUNC_CALL;
	IF = 'if';
	THEN = 'then';
	ELSE = 'else';
	FOR = 'for';
	TO = 'to';
	DO = 'do';
	WHILE = 'while';
	AND = 'and';
	OR = 'or';
	XOR = 'xor';
}

@lexer::namespace { PascalCompiler }
@parser::namespace { PascalCompiler }

@header {
  using System.Collections.Generic;
  using System.Globalization;
}

@members {
  // number format with decimal separator - '.'
  public static readonly NumberFormatInfo NFI = new NumberFormatInfo();
  private Stack<String> stack = new Stack<String>();
  }
  
BOOLEAN :
	('true')|('false')	
	;

IDENT:	
	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*
    ;

NUMBER:   
    ('0'..'9')+ ('.' ('0'..'9')+)?
    |   '.' ('0'..'9')+ 
    ;

COMMENT
	:
	'//' ~('\n'|'\r')* '\r'? '\n' {$channel=HIDDEN;}
	 |   '{' ( options {greedy=false;} : . )* '}' {$channel=HIDDEN;}
	 ;
	 
STRING	:
	'"' (('\\"') | (~'"'))* '"'
	;

WS:
    ( ' ' | '\t' | '\f'| '\r' | '\n' )+ {$channel=HIDDEN;}
    ;
    
ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIV:    '/'     ;
ASSIGN: ':='    ;
COMPARE: '>' | '>=' | '<' | '<=' | '=' | '!=';
    
group 
	:
	'('! term ')'!
	| NUMBER -> NUMBER<NumAstNode>[double.Parse($NUMBER.text, NFI)]
	| BOOLEAN
	| func_call
	| IDENT
	| STRING -> STRING<StringAstNode>[$STRING.text]
	;
      
mult: group ( ( MUL | DIV | AND )^ group )*  ;
add:  mult  ( ( ADD | SUB | OR | XOR )^ mult  )*  ;
compare	: add ( COMPARE^ add)*;
term	: compare;

arg_list: ( term (','! term)* )? ;

func_call
	:
	IDENT ('(' arg_list ')' ) -> ^(FUNC_CALL IDENT ^(PARAMS arg_list)?)
	;

expr	:
	IDENT ASSIGN^ term
	| func_call
	| BLOCKOPEN expr_list BLOCKEND -> ^(BLOCK expr_list)
	| IF^ compare THEN! expr (ELSE! expr)?
	| FOR^ IDENT ASSIGN! add TO! add DO! expr
	| WHILE^ compare DO! expr
	| DO^ expr WHILE! compare
	;
    
expr_list 
	:
	(';'!)* expr ( (';'!)+ expr )* (';'!)*
	;
	
program_body
	:	
	expr_list -> ^(BLOCK expr_list)
	;
	
ident_list
	:	
	IDENT (','! IDENT)*
	;
	
type	:	
	':' IDENT -> ^(IDENT)
	;
	
variables_definition
	:
	VAR (ident_list type SEMICOLON+)+ -> ^(VAR ^(type ident_list)+)
	;
	
params_definition
	:	
	(ident_list type) -> ^(type ident_list)
	;
	
method_definition
	:	
	(PROCEDURE IDENT ('(' (params_definition (';' params_definition)*)? ')')? SEMICOLON methods_definition? 
	variables_definition? BLOCKOPEN expr_list BLOCKEND) 
	-> ^(PROCEDURE<ProcedureAstNode>[$IDENT.text] ^(PARAMS params_definition*)? methods_definition? variables_definition? ^(BLOCK expr_list))
	|
	(FUNCTION IDENT ('(' (params_definition (';' params_definition)*)? ')')? type SEMICOLON methods_definition? 
	variables_definition? BLOCKOPEN expr_list BLOCKEND) 
	-> ^(FUNCTION<FunctionAstNode>[$IDENT.text, ""] type ^(PARAMS params_definition*)? methods_definition? variables_definition? ^(BLOCK expr_list))
	;
	
methods_definition
	:	
	method_definition (SEMICOLON method_definition)* SEMICOLON* -> ^(METHODS method_definition*)
	;
    
program	
	:
	PROGRAM IDENT SEMICOLON methods_definition? variables_definition?  BLOCKOPEN program_body BLOCKEND '.'
	 -> ^(PROGRAM<ProgAstNode>[$IDENT.text] methods_definition? variables_definition? program_body)
	;
    
result	
	:	
	program
	;
    
execute	
	:	
	result
	;



