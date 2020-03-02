using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {


            int len = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();

            //int len = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();

            //string s = "abcabcabcab";
            //string s = "abaaabcccab";
            // string s = "beabeefeab";//babab -> 5
            //string s = "ggzczxoxwqeihjsswxwxkuxqwcyeuxrppajcyrzahehomrlqzfesagmietjqtwsrioocnjqgggpzzkmxxqlujnqormwffsmhoatqbezymyhxwjtayyilozozzwbhhkewgimejokyvsyobcfprzjdgnhwitwsdssjohhvkvgwpxcnanqufqbskubxxiajpclpraimeozhvpwagabvhjndinvuhfzqlcvbfnkosqdsdzznsibukhlltcgaezcvlsrkbexelggocseryhqyntrolpskbgojetdaidcbcbiwzsemactmumjemlqkbqyqxbgjaqynnworreqbyqyawpqyuorkoqdlvovyqkvyqxffhbfcjabcqribrikvraivghmdssjqywbtkuzhoeltouoztkdjgupiwyowglrtttgcjxnnmvkihxckbayxwcjiyyrymomqclchpiorftyuuuccymzbzobltxojsdzdrtvqwcvclsfbkvxsdcncgzpjwjwvgyxzptjjscmujoslgx";
            //string s = "aaaaaaaabbbbbbbbbbccccccccccccccdddddddddddddddddeeee";

            //string s = "nvqredbicypfcjjlolkpeyhgydrfmxaqzhrviwwwgxogqtflzvtsouerbeiotzhyobsecdrscvzfmndvitkotptnphcodrcwpqwtleemoavgtswzhcfkwurfiottvqperjjuoonawtvavtaftytjritdvhmwnzdjklqsuxfpdkrkaseaaqejeukckpwmnqsbcpfosobpmrpuphavimqcdbsituzsfuvnnljdditlgcjfbputtztyhqekqqmuedrkzvtjtoypfeojzieasapvphsnyhuybgwlfwjvmemullymsdqcbsxmxlusatbefpddktxrmyabhbbhaghghxugzhjtllvugbemwabbqxodinikujcxgatrozdowykbvkugqtmzzgdrsfeoimizypzjecadsfkgcwroonzcfwksobusoopcflwmledyrwfrcmwklqtohbuncujlzbuumfigweoitttnafdwrwewggyloztuoaobcmixhokmucjrlvkjculzffenchjutphqiuqkfxxnnelsoueipwjxxhezndpfaejxtrvdilupzcwwdutnizzkmzdrsqiezwzlredarocnasvxfcjtzeiwhvxocstizmxvqlijgmvvwinegscvccsgkdxjtletpqlqpjtvumvzgqadtrciirabreewrfzvbhcqiswnfhjfbathkqtyxwgtuubrxgqxwraoeckljlfwjodjkzucmkabktaxzhdws";
            //string s = "muqqzbcjmyknwlmlcfqjujabwtekovkwsfjrwmswqfurtpahkdyqdttizqbkrsmfpxchbjrbvcunogcvragjxivasdykamtkinxpgasmwz";

            /* 0 */
            //string s = "nvqredbicypfcjjlolkpeyhgydrfmxaqzhrviwwwgxogqtflzvtsouerbeiotzhyobsecdrscvzfmndvitkotptnphcodrcwpqwtleemoavgtswzhcfkwurfiottvqperjjuoonawtvavtaftytjritdvhmwnzdjklqsuxfpdkrkaseaaqejeukckpwmnqsbcpfosobpmrpuphavimqcdbsituzsfuvnnljdditlgcjfbputtztyhqekqqmuedrkzvtjtoypfeojzieasapvphsnyhuybgwlfwjvmemullymsdqcbsxmxlusatbefpddktxrmyabhbbhaghghxugzhjtllvugbemwabbqxodinikujcxgatrozdowykbvkugqtmzzgdrsfeoimizypzjecadsfkgcwroonzcfwksobusoopcflwmledyrwfrcmwklqtohbuncujlzbuumfigweoitttnafdwrwewggyloztuoaobcmixhokmucjrlvkjculzffenchjutphqiuqkfxxnnelsoueipwjxxhezndpfaejxtrvdilupzcwwdutnizzkmzdrsqiezwzlredarocnasvxfcjtzeiwhvxocstizmxvqlijgmvvwinegscvccsgkdxjtletpqlqpjtvumvzgqadtrciirabreewrfzvbhcqiswnfhjfbathkqtyxwgtuubrxgqxwraoeckljlfwjodjkzucmkabktaxzhdws";
            //string s = "czoczkotespkfjnkbgpfnmtgqhorrzdppcebyybhlcsplqcqogqaszjgorlsrppinhgpaweydclepyftywafupqsjrbkqakpygolyyfksvqetrfzrcmatlicxtcxulwgvlnslazpfpoqrgssfcrfvwbtxaagjfahcgxbjlltfpprpcjyivxu";

            /* 6 */
            //string s = "czoczkotespkfjnkbgpfnmtgqhorrzdppcebyybhlcsplqcqogqaszjgorlsrppinhgpaweydclepyftywafupqsjrbkqakpygolyyfksvqetrfzrcmatlicxtcxulwgvlnslazpfpoqrgssfcrfvwbtxaagjfahcgxbjlltfpprpcjyivxu";

            if (s.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                string dist = new String(s.Distinct().ToArray());
                Console.WriteLine(dist);
                HashSet<string> pares = new HashSet<string>();

                int max_len = 0;

                for (int i = 0; i < dist.Length; i++)
                {
                    for (int j = i + 1; j < dist.Length; j++)
                    {
                        char x = dist[i];
                        char y = dist[j];

                        string p1 = x.ToString() + y.ToString();
                        string p2 = y.ToString() + x.ToString();

                        if (!pares.Contains(p1) && !pares.Contains(p2))
                        {
                            pares.Add(p1);
                            pares.Add(p2);

                            string concat = "";
                            for (int k = 0; k < s.Length; k++)
                            {
                                if (s[k] == x || s[k] == y)
                                {
                                    concat += s[k];

                                    if (concat.Length > 1 && concat[concat.Length - 1] == concat[concat.Length - 2])
                                    {
                                        concat = "";
                                        break;
                                    }
                                }
                            }
                            //if (concat.Length == 6)
                            //{
                            //    Console.WriteLine(x + " " + y + " "+ concat);
                            //}

                            //  Console.WriteLine(concat);
                            max_len = Math.Max(max_len, concat.Length);
                        }

                    }
                }

                Console.WriteLine(max_len);
            }


            Console.ReadLine();
        }


        //static void Main(string[] args)
        //{
        //    string s = "muqqzbcjmyknwlmlcfqjujabwtekovkwsfjrwmswqfurtpahkdyqdttizqbkrsmfpxchbjrbvcunogcvragjxivasdykamtkinxpgasmwz";

        //    string concat = "";
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] == 'm' || s[i] == 'p')
        //        {
        //            concat += s[i];
        //        }
        //    }
        //    Console.WriteLine(concat);

        //    Console.ReadLine();
        //}
    }
}

