namespace ClassesExercicios2
{
    class Alunos
    {
        public string Nome;
        public double A, B, C;

        public double NotaFinal()
        {
            return A + B + C;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
