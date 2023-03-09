using System; 

//Developed by: @LucasMarcuzo
class URI1047 {

    static void Main(string[] args) { 
 
        int h1, m1, s1, h2, m2, s2, tempo, hr, min;

        string[] s = Console.ReadLine().Split(' ');

        h1=int.Parse(s[0]);
        m1=int.Parse(s[1]);
        h2=int.Parse(s[2]);
        m2=int.Parse(s[3]);

        if (h2 <= h1 && m2 <= m1) 
        {
            h2 = h2 + 24;

        }else if (m2 <= m1) 
        { 
            m2 = m2 + 60;
            h2 = h2 - 1;
        }

        s1 = (h1 * 3600) + (m1 * 60);
        s2 = (h2 * 3600) + (m2 * 60);

        tempo = (s2 - s1);
        hr = tempo / 3600;
        min = (tempo - (hr * 3600)) / 60;

        Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hr, min);
    }
}



//easy and understandable way:
using System; 

class URI1047 {

    static void Main(string[] args) { 
 
        int start_h = 0, start_m = 0, end_h = 0, end_m = 0;
        int duration, hr, min;

        string[] s = Console.ReadLine().Split(' ');

        start_h = int.Parse(s[0]);
        start_m = int.Parse(s[1]);
        end_h = int.Parse(s[2]);
        end_m = int.Parse(s[3]);
        
        duration = (end_h * 60 + end_m) - (start_h * 60 + start_m);
        if(duration <= 0){
            duration = duration + (60*24);
        }
        
        hr = duration / 60;
        min = duration % 60;
        
        Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hr, min);
    }
}
