%namespace GPLexTutorial

%%
/* Benliang Shi, Student number 9623001*/

LF                           { return (int)Tokens.LF; }
CR                           { return (int)Tokens.CR; }
abstract                     { return (int)Tokens.ABSTRACT; }
assert                       { return (int)Tokens.ASSERT; }
if                           { return (int)Tokens.IF; }
else                         { return (int)Tokens.ELSE; }
int                          { return (int)Tokens.INT; }
bool                         { return (int)Tokens.BOOL; }

[ \r\n\t]                    /* skip  the whitespace */

.                            { 
                                 throw new Exception(
                                     String.Format(
                                         "unexpected character '{0}'", yytext)); 
                             }

%%
