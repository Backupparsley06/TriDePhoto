using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriDePhoto
{
    class ProbabilityGenerator
    {
        private int numerateur;
        private int denominateur;
        Random random;
        public ProbabilityGenerator(int numerateur, int denominateur)
        {
            this.numerateur = numerateur;
            this.denominateur = denominateur;
            random = new Random();
        }

        public bool GetRandom()
        {
            return (random.Next() % denominateur) < numerateur;
        }
    }
}
