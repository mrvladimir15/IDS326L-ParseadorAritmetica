using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDS326L_ParseadorAritmetica
{
    internal class Aritmetica : aritmeticaBaseVisitor<int>
    {
        public override int VisitAritmetica([NotNull] aritmeticaParser.AritmeticaContext context)
        {
            Console.WriteLine($"Visitando aritmética: {context.GetText()}");
            return base.VisitAritmetica(context);
        }

        public override int VisitExpresion([NotNull] aritmeticaParser.ExpresionContext context)
        {
            Console.WriteLine($"Visitando expresión: {context.GetText()}");
            return base.VisitExpresion(context);
        }

        public override int VisitFactor([NotNull] aritmeticaParser.FactorContext context)
        {
            Console.WriteLine($"Visitando factor: {context.GetText()}");
            return base.VisitFactor(context);
        }

        public override int VisitTermino([NotNull] aritmeticaParser.TerminoContext context)
        {
            Console.WriteLine($"Visitando término: {context.GetText()}");
            return base.VisitTermino(context);
        }
    }
}
