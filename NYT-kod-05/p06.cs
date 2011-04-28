using System;

namespace OrnekSiniflar
{
    public class Cevherler
    {
        // A: altin, G: gumus, B: bakir
        public string[] hammadde;
        public string[] degerli_elementler;

        public Cevherler(string[] arg_hammadde, string[] arg_degerli_e)
        {
            hammadde = arg_hammadde;
            degerli_elementler = arg_degerli_e;
        }
    }

    public class Fabrika
    {
        public static bool Dedektor(char numune, string[] metaller)
        { 
            // numune olarak alinan parca, aranan degerli
            // metallerden herhangi birisi mi?
            bool sonuc = false;
            for (int i = 0; i < metaller.Length; i++)
            {
                if (System.Convert.ToString(numune) == metaller[i])
                    sonuc = true;
            }
            return sonuc;
        }

        public static string[] OnIsleme(Cevherler cvh)
        { // degerli metalleri hammaddeden cikarma
            string[] islenen = new string[cvh.hammadde.Length];
            int indeks = 0;


            foreach (string cevher in cvh.hammadde)
            {
                for (int i = 0; i < cevher.Length; i++)
                {
                    if (Dedektor(cevher[i], cvh.degerli_elementler))
                        islenen[indeks] += cevher[i];
                }
                indeks++;
            }
            return islenen;
        }

        public static string Ayristirma(string[] OnislemeCiktisi, string[] metaller)
        { // cikarilan degerli metalleri ayristirma
            int[] miktar_say = new int[metaller.Length];
            int m_s_indx = 0;
            string AyristirmaSonucu = "";

            foreach (string metal in metaller)
            {
                foreach (string cikti in OnislemeCiktisi)
                {
                    if (cikti == null)
                        continue; // hammaddede degerli element yoksa
                    for (int i = 0; i < cikti.Length; i++)
                    {
                        if (System.Convert.ToString(cikti[i]) == metal)
                            miktar_say[m_s_indx]++;
                    }
                }
                AyristirmaSonucu += "[" + System.Convert.ToString(miktar_say[m_s_indx]) + " x " + metal + "] ";
                m_s_indx++;
            }

            return AyristirmaSonucu;
        }
    }

    public class Sinif1
    {
        static void Main()
        {
            string[] hammadde1 = { "%++&%&A3-GG!&.%AG)/&B%!!B", "|&((GB}}A%%#B[£;£//*?*G..", ";&$B&///++',&=)'/,/_-[£{=", "G_&/%B,&+#AG%!)%%-.B-**&$", "./&%BB+B#}GB,==,&!*£G[%&!" };
            string[] degerli_metaller_1 = { "A", "G", "B" };
            Cevherler cevher1 = new Cevherler(hammadde1, degerli_metaller_1);
            string[] onisleme_cikisi1 = Fabrika.OnIsleme(cevher1);
            string ayristirma_sonucu1 = Fabrika.Ayristirma(onisleme_cikisi1, cevher1.degerli_elementler);
            Console.WriteLine("cevher1 --> {0}", ayristirma_sonucu1);

            string[] hammadde2 = { "#$=G&--BAG,%%4", "/%G...B", "-A;", "+B/&==)(G}AB" };
            string[] degerli_metaller_2 = { "A" };
            Cevherler cevher2 = new Cevherler(hammadde2, degerli_metaller_2);
            string ayristirma_sonucu2 = Fabrika.Ayristirma(Fabrika.OnIsleme(cevher2), cevher2.degerli_elementler);
            Console.WriteLine("cevher2 --> {0}", ayristirma_sonucu2);

            Console.ReadLine();
        }
    }
}
