using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MON_PROJEKT
{
    static class Music
    {

        public static void MusicDesert()
        {

            Console.Beep(294, 600); // D
            Console.Beep(311, 200); // Eb
            Console.Beep(370, 600); // F#
            Console.Beep(392, 400); // G
            Console.Beep(370, 400); // F#
            Console.Beep(311, 400); // Eb
            Console.Beep(294, 600); // D
        }


        public static void Forest1()
        {

        }

        public static void Forest2()
        {
            Console.Beep(224, 600); // Tiefer Grundton
            Console.Beep(587, 200); // D5 – "Bu"
            Console.Beep(659, 200); // E5 – "ffa"
            Console.Beep(224, 600); // Tiefer Grundton
            Console.Beep(784, 200); // G5 – "lo"
            Console.Beep(659, 200); // E5 – "sol"
            Console.Beep(224, 600); // Tiefer Grundton
            Console.Beep(587, 200); // D5 – "di"
            Console.Beep(523, 200); // C5 – "er"
        }

        public static void Forest3()
        {
            Console.Beep(224, 600); // Tiefer Grundton
            Console.Beep(659, 200); // E5 – "Bad"
            Console.Beep(784, 200); // G5 – "boys"
            Console.Beep(224, 600); // Tiefer Grundton
            Console.Beep(659, 200); // E5 – "bad"
            Console.Beep(523, 200); // C5 – "boys"
            Console.Beep(224, 600); // Tiefer Grundton
            Console.Beep(440, 200); // A4 – "what"
            Console.Beep(587, 200); // D5 – "you"


        }

        public static void Forest4()
        {
    Console.Beep(224, 600); // Tiefer Grundton
    Console.Beep(440, 200); // A4 – "Could"
    Console.Beep(523, 200); // C5 – "you"
    Console.Beep(224, 600); // Tiefer Grundton
    Console.Beep(587, 200); // D5 – "be"
    Console.Beep(659, 200); // E5 – "loved"
    Console.Beep(224, 600); // Tiefer Grundton
    Console.Beep(784, 200); // G5 – "and"
    Console.Beep(659, 200); // E5 – "be"
        }

        public static void MusicSwamp()
        {
            Console.Beep(224, 800);         // Beat
            Console.Beep(392, 300);         // G4
            Console.Beep(440, 300);         // A4
            Console.Beep(224, 800);         // Beat
            Console.Beep(466, 300);         // Bb4
            Console.Beep(587, 300);         // D5
            Console.Beep(224, 800);         // Beat
        }

        public static void Jingle_Polar()
        {
            Console.Beep(784, 200); // G5
            Console.Beep(880, 200); // A5
            Console.Beep(988, 200); // B5
            Console.Beep(1175, 250); // D6
            Thread.Sleep(100);
            Console.Beep(1046, 300); // C6
            Console.Beep(880, 400); // A5
        }


        public static void Jingle_Volcano()
        {
            Console.Beep(440, 300); // A4
            Console.Beep(392, 250); // G4
            Console.Beep(349, 250); // F4
            Console.Beep(330, 200); // E4
            Thread.Sleep(50);
            Console.Beep(294, 300); // D4
            Console.Beep(220, 600); // A3
        }


        public static void Jingle_Sky()
        {
            Console.Beep(784, 200); // G5
            Console.Beep(880, 200); // A5
            Console.Beep(988, 200); // B5
            Console.Beep(1046, 200); // C6
            Console.Beep(1175, 300); // D6
            Console.Beep(1319, 300); // E6
        }

        public static void Jingle_PowerPlant()
        {
            Console.Beep(880, 150);  // A5
            Console.Beep(660, 150);  // E5
            Console.Beep(880, 150);  // A5
            Console.Beep(1320, 100); // E6
            Thread.Sleep(50);
            Console.Beep(880, 200);  // A5
            Console.Beep(660, 250);  // E5
            Console.Beep(440, 300);  // A4
        }

        public static void Jingle_Nightlands()
        {
            Console.Beep(440, 250); // A4
            Console.Beep(392, 200); // G4
            Console.Beep(349, 250); // F4
            Console.Beep(330, 250); // E4
            Thread.Sleep(100);
            Console.Beep(220, 400); // A3
            Console.Beep(196, 500); // G3
        }


        public static void Jingle_Wueste1()
        {
            Console.Beep(294, 250);  // D4
            Console.Beep(311, 200);  // Eb4
            Console.Beep(370, 250);  // F#4
            Console.Beep(392, 300);  // G4
            Thread.Sleep(100);
            Console.Beep(294, 250);  // D4
            Console.Beep(370, 250);  // F#4
            Console.Beep(466, 400);  // A#4 (Bb4)
            Thread.Sleep(150);
            Console.Beep(392, 400);  // G4
        }

        public static void Jingle_Wueste2()
        {


            // Verzierter Abstieg mit rhythmischem Ornament
            Console.Beep(523, 150); // C
            Console.Beep(466, 150); // Bb
            Console.Beep(440, 200); // A
            Console.Beep(392, 200); // G
            Console.Beep(370, 250); // F#
            Thread.Sleep(50);
            Console.Beep(311, 250); // Eb
            Console.Beep(294, 600); // D
        }


        public static void Jingle_Wueste4()
        {
            Console.Beep(294, 300);  // D4
            Console.Beep(349, 300);  // F4
            Thread.Sleep(100);
            Console.Beep(392, 400);  // G4
            Console.Beep(440, 400);  // A4
            Thread.Sleep(150);
            Console.Beep(392, 300);  // G4
            Console.Beep(294, 500);  // D4
        }
        public static void Jingle_Wueste5()
        {
    Console.Beep(330, 200);  // E4
    Console.Beep(370, 200);  // F#4
    Console.Beep(415, 200);  // G#4
    Thread.Sleep(100);
    Console.Beep(554, 300);  // C#5
    Console.Beep(494, 300);  // B4
    Console.Beep(440, 400);  // A4
}

        public static void Jingle_Postapokalypse()
        {
            Console.Beep(220, 400); // A3
            Console.Beep(196, 300); // G3
            Console.Beep(165, 400); // E3
            Thread.Sleep(200);
            Console.Beep(220, 300); // A3
            Console.Beep(247, 200); // B3
            Console.Beep(196, 600); // G3
        }

        public static void Jingle_Duester()
        {
            Console.Beep(880, 150); // A5
            Console.Beep(415, 300); // G#4
            Console.Beep(622, 100); // D#5
            Thread.Sleep(100);
            Console.Beep(330, 400); // E4
            Console.Beep(220, 500); // A3
            Console.Beep(165, 700); // E3
        }

        public static void Jingle_Funky()
        {
            Console.Beep(659, 150); // E5
            Console.Beep(784, 150); // G5
            Console.Beep(880, 150); // A5
            Console.Beep(659, 150); // E5
            Console.Beep(988, 300); // B5
            Thread.Sleep(100);
            Console.Beep(880, 200); // A5
            Console.Beep(784, 200); // G5
        }

        public static void Jingle_Fantasy()
        {
            Console.Beep(523, 200); // C5
            Console.Beep(587, 200); // D5
            Console.Beep(659, 200); // E5
            Console.Beep(698, 300); // F5
            Console.Beep(784, 500); // G5
            Thread.Sleep(150);
            Console.Beep(880, 400); // A5
            Console.Beep(988, 700); // B5
        }

    }
}

