namespace VsCodeC_Into;

//Dette representerer samlingen av kode som inneholder hele programmet vårt.
//Det er her Runtimen leter etter "starten" på programmet vårt når vi kompilerer ned.
//Er ofte abstraktert vekk hvis ikke vi bruker flagget --use-program-main når vi genererer et prosjekt. 
class Program
{
    //Dette representerer starten av koden som skal kjøres av programmet vårt.
    //Det er her runtimen starter å "kjøre" kode når vi skriver dotnet run.
    //Er ofte abstraktert vekk hvis vi ikke bruker flagget --use-program-main når vi genererer et prosjekt. 
    static void Main(string[] args)
    {
        //Her lagrer vi teksten "Hello, World!" som en variabel vi kan bruke igjen senere i koden vår.
        //For å definere en variabel i C# trenger vi å gi koden vår tre ting.
        // 1. string representerer datatypen variabelen vår skal ha. string er datatypen som representerer en sett tekst.
        // 2. helloText representerer navnet på variabelene vår. Det er dette navnet vi bruker for å referere til denne variablen senere i teksten vår.
        // 3. "Hello, World!" er verdien vår variabel skal holde, tekststrenger i C# bruker hermetegn " " for å inkapsle teksten som skal representeres.
        string helloText = "Hello, World!";

        //Her finner vi WriteLine metoden til System.Console.
        //WriteLine er en metode som kan skrive en beskjed til systemets terminal. Når vi kjører programmet i VSCode refererer det til terminalen i VSCode. 
        //Inni parantesen til WriteLine bruker vi vår variabel helloText som et parameter, det betyr at WriteLine bruker verdien til helloWorld når den skal finne ut hva den skal skrive ut i terminal.
        System.Console.WriteLine(helloText);

        //System.Console representerer et set med ferdigskrevet kode.
        //System representerer namespacet som har med ferdigskrevet systemkode å gjøre, og inneholder flere forksjellige samlinger med kode (Classes) for å manipulere Systemet på forskjellige måter.
        //Her finner vi ForegroundColor propertien til Console, og endrer den til fargen Rød. 
        System.Console.ForegroundColor = ConsoleColor.Red;
        //Vi bruker så WriteLine metoden til Console og skriver ut en tekst for å se at fargen endres til rød.
        System.Console.WriteLine("I am red text!");
        //Vi bruker så ResetColor metoden for å resette tilbake til systemets default farge for text i terminalen.
        System.Console.ResetColor();
        // System som namespace er også noe som ofte blir abstraktert vekk når vi skriver kode. Compileren til C# antar ofte at når lager et prosjekt i C#, at systemkode alltid skal være tilgjengelig.
        //Herfra og nedover skipper vi System fremfor Console, men det refererer til samme sett med ferdigskrevet kode. C# compileren er smart nok til å vite vi vil hente ut samme sett med kode.

        //I C# har vi mange former for datatyper, de viktigste er de primære datatypene, talltypene.
        //Alle primærtypene i C# har en maksverdi, knyttet til hvor mye plass i minnet datatypen trenger for å opperere.

        //int er en talltype som representerer et helt tall. 
        //int krever 32 bits av lagerplass fra datamaskinen vår. 
        int heltTall = 10;
        Console.WriteLine(heltTall);

        //Double er standard talltypen for å opperere med desimal tall i C#. 
        //doubles bruker 64 bits av lagerplass fra datamaskinen vår. 
        //doubles er bare nøyaktig ned til 16 desimalplasser. Har vi flere desimaltall enn det kan tallet fort lagres som et annet tall.
        //14.999999999999999 lagres helt fint, men
        //14.99999999999999999 kan fort bli lagret som tallet 15 i datamaskinens minne.
        double desimalTall = 10.3;
        Console.WriteLine(desimalTall);


        //Floating points er en mindre nøyaktig måte å skrive desimaltall på i C#. 
        //De er bare nøyaktig ned til 11 desimalplasser.
        //Floatingpoints trenger bare 32 bits av datamaskinen.
        //Siden floating points ikke er standardmåten å lagre desimaltall på i C#, trenger datamaskinen litt mer informasjon om hva verdien skal være. Legg merke til bokstaven f etter tallverdien, for å definere en floating point.
        float floatingPoint = 10.3f;
        Console.WriteLine(floatingPoint);


        //Decimal er en datatype som er enda mer nøyaktig i C# enn en double.
        //Decimal lagrer desimaltall på en litt annen måte enn floating precision points(double og floats). og er derfor annsett som svært nøyaktig.
        //decimal trenger 128 bits av datamaskinen. 
        decimal faktiskDesimalTall = 10.3m;
        Console.WriteLine(faktiskDesimalTall);

        //long er en større datatype enn int for å lagre hele tall, lagrer på samme måte.
        //bruker 64 bits av datamaskinen. 
        long heltTallMenStørre = 10;
        Console.WriteLine(heltTallMenStørre);

        //Karakterer er også lagret som tall i C#.
        //Der bruker de et tall for å finne et tegn i et lookup table som heter UTF-16. 
        //En char bruker 16 bits av datamaskinen vår. 
        //Er nesten interchangeable mellom en int. 
        char detteErOgsåEtTall = 'a';

        int bokstavMinusTall = detteErOgsåEtTall - 2;
        Console.WriteLine(bokstavMinusTall);

        //Eksempel på største positive verdien til en integer.
        int positivMaksverdi = 2147483647;
        Console.WriteLine(positivMaksverdi);

        //Eksempel på en double med for mange desimaltall.
        double forStortDesimalTall = 10.999999999999999999;
        Console.WriteLine(forStortDesimalTall);


        //Tildelingsoperatorer.
        //Tildelingsoperatorer vil alltid overskrive verdien i variablen vi oppererer med. 

        // = Tildeler verdier til variabler.
        double mittTall = 10;
        Console.WriteLine(mittTall);

        // += henter ut verdien fra variabelen, legger til 5 til verdien, før den overskriver den gamle verdien med resultatet.
        mittTall += 5;
        Console.WriteLine(mittTall);

        // -= henter ut verdien fra variabelen, trekker fra 2, før den overskriver den gamle verdien med resultatet.
        mittTall -= 2;
        Console.WriteLine(mittTall);

        // /= henter ut verdien fra variablen, deler verdien på 4, før den overskriver den gamle verdien med resultatet.
        mittTall /= 4;
        Console.WriteLine(mittTall);

        // *= henter ut verdien fra variablen, ganger den med 3, før den overskriver den gamle verdien med resultatet.
        mittTall *= 3;
        Console.WriteLine(mittTall);

        // %= henter ut verdien fra variablen, deler tallet på 7, og overskriver den gamle verdine med divisoren av resultatet. 
        mittTall %= 7;
        Console.WriteLine(mittTall);



        // aritmetriske operatorer.
        //Gjør aritrmi med to verdier, kan lagre resultatet til en ny verdi uten å overskrive de gamle verdiene.
        double num1 = 2;
        double num2 = 4;

        //Lager en ny verdi addedNums som er resultatet av num1 + num2.
        double addedNums = num1 + num2;
        Console.WriteLine(addedNums);

        //lager en ny verdi subtractedNums som er resultatet av num1 - num2.
        double subtractedNums = num1 - num2;
        Console.WriteLine(subtractedNums);

        //lager en ny verdi dividedNums som er resultatet av num1 / num2.
        double dividedNums = num1/num2;
        Console.WriteLine(dividedNums);

        //lager en ny verdi multipliedNums som er resultatet av num1 * num2.
        double multipliedNums = num1*num2;
        Console.WriteLine(multipliedNums);

        //Lager en ny verdi moduloNums som er resultatet av num1 % num2.
        double moduloNums = num1 % num2;
        Console.WriteLine(moduloNums);



        //Sammenligningsoperatorer.
        //Sammenligningsoperatorer gjør sammenligninger av to verdier, og leverer resultatet som en bool (true eller false).

        // == ser om to verdier er lik.
        bool erLikVerdi = num1 == num2;
        Console.WriteLine(erLikVerdi);

        // != ser om to verdier er ulik
        bool erUlikVerdi = num1 != num2;
        Console.WriteLine(erUlikVerdi);

        // > ser om venstre siden er større enn høyre siden. er num1 større enn num2.
        bool erStørreEnn = num1 > num2;
        Console.WriteLine(erStørreEnn);

        // < ser om venstre siden er mindre enn høyre siden. er num1 mindre enn num2.
        bool erMindreEnn = num1 < num2;
        Console.WriteLine(erMindreEnn);


        //LogikkOperatorer

        // && også operator

        bool andEqual = num1 == 2 && num2 == 4;
        //Statementen her spør følgende: er num1 lik tallet 2 OG er num2 lik tallet 4? Begge må stemme for at vår statement skal være sann.
        Console.WriteLine(andEqual);

        // || eller operator

        bool orEqual = num1 == 2 || num2 == 8;
        //Statementen her spør følgende: er num1 lik tallet 2, ELLER er num2 lik tallet 8? Bare en av spørringene må være sann, for at hele spørringen er sann. 
        Console.WriteLine(orEqual);

        // ! omvendt opperator

        bool oppositeEqual = !andEqual;
        //Statementen her sier at vår bool oppositeEqual skal være det omvende av andEqual.
        Console.WriteLine(oppositeEqual);


        //Bitwise operatorer
        int five = 0b0101;
        int three = 0b0011;

        //Bitwise And / Og

        int bitAnd = five & three;
        //0001 svaret er tallet 1;
        Console.WriteLine(bitAnd);

        //Bitwise Or / Eller;

        int bitOr = five | three;
        //0111 eller tallet 7;
        Console.WriteLine(bitOr);

        // Eklusiv Eller / xOr

        int bitXOr = five ^ three;
        //0110 eller tallet 6;
        Console.WriteLine(bitXOr);

        //Not / bitOpposite / Ikke

        int bitNot = ~five;
        //1010, eller tallet -6;
        Console.WriteLine(bitNot);

        //Her ser koden vår at vi refererer til en blokk, så runtimen som leser koden vår, henter blokken fra hvornåenn den er. og kjører den. 
        double getNumFromBlock = BlockDefinedDouble();
        Console.WriteLine(getNumFromBlock);

        //statement blokk som runtimen henter for å vite hva den skal kjøre på linje 215. denne type blokk blir også kalt metode. 
        double BlockDefinedDouble()
        {
            double myNum = 10;
            return myNum;
        }
    }
}   