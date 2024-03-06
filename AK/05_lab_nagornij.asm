; R9 - x
; a = 12
; 016 - переходити якщо X менше a
; 029 - переходити якщо X НЕ задовільняє умову функції
; 031 - OUTPUT
IN
WR R9
SUB #12 ;Перевірка
JS 016
; Fi
RD #50 ;Перевірка
SUB R9
JS 029
RD R9
SUB #1
JS 029
RD R9
ADD #3
WR R1
MUL R1
DIV R9
JMP 031
; Fj
RD #12 ;Перевірка
SUB R9
JS 029
RD R9
SUB #2
JS 029
RD #1
SUB R9
WR R1
RD R9
ADD #17
DIV R1
JMP 031
RDI #199999
OUT
HLT