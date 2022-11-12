using Antlr4.Runtime;
using IDS326L_ParseadorAritmetica;

string input = "5*6+9*3-1";
Console.WriteLine($"Input: {input}");
ICharStream stream = CharStreams.fromString(input);
aritmeticaLexer lexer = new aritmeticaLexer(stream);
CommonTokenStream tokens = new CommonTokenStream(lexer);
aritmeticaParser parser = new aritmeticaParser(tokens);
var tree = parser.aritmetica();
Aritmetica aritmetica = new Aritmetica();
int res = aritmetica.Visit(tree);