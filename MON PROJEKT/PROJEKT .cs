using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

PROJEKT – DENNIS KÖNIG, FI (AE ?) 24-4

Ziel des Projekts ist ein RPG mit
A) MONS, also spielbaren Charakteren mit bestimmten Eigenschaften (Klassen & Methoden. für Eigenschaften und Stats List oder lieber Dictionary?)
B) STORY UND PSEUDO-„OVERWORLD“,  in denen man sich rudimentär textbasiert bewegen und Fortschritte erzielen kann,
C) ATTACKEN mit bestimmten Eigenschaften, die  von den Mons in einem
D) KAMPFSYSTEM genutzt werden können.
Es ist inspiriert von Pokemon, FF, Chrono Trigger, Dragon Quest Monsters etc.

TAG 1
A // MONS
            //CHECK     initialisiere MONS;
            //CHECK     mons haben NAME;
            //CHECK     mons haben GENOS: THERIOID / SAUROID / AMPHIBIOID / ORNITHOID / ICHTHYOID / ASPONDYLOID / PHYTOID / ORGANOID;
            //CHECK     mons haben TYP: EARTH, BIO, TOXIN, WATER, ICE, FIRE, AIR, LIGHTNING, SHADOW;
            // mons haben HOME BONUS
            //CHECK     mons haben SIMPLE GRAFIK (string "" ZEICHENSYMBOLE + FARBE);
            //CHECK     mons haben CRY (BEEP);
            // mons haben EXP-BAR (string "?" MIT FARBE);
            // mons haben LEVEL;
            //CHECK     mons haben IMMER EINE KLASSE: STARTKLASSE "BASE";
            // mons haben ZUGANG ZU 3/5 KLASSEN: ("BASE" /) "FIGHTER" / "SPELLCASTER" / "ROGUE" / "MECHANIC" / "HEALER";
            // mons KÖNNEN KLASSE ÄNDERN (EINMALIGE AUSBILDUNG VON "BASE")
            //CHECK     mons haben JE 8 STATS: HP / STAMINA / PHY ATK / PHY DEF / PSYMINA / PSY ATK / PSY DEF / SPEED;
            // mons haben JE 4 ATTACKEN
            //CHECK     mons haben ATTACK LEARNSET;
            //CHECK     mons haben GEWICHT: FEATHERWEIGHT / LIGHTWEIGHT / MIDDLEWEIGHT / HEAVYWEIGHT / SUPER HEAVYWEIGHT;
[ADDED AFTER GREEN LIGHT]    // mons können zum HQ geschickt werden, wenn kein platz mehr in der Gang ist;

// ALLE MON INFOS KÖNNEN ABGEFRAGT WERDEN!

TAG 2

B // CORE / STORY / OVERWORLD
            // CW: INTRO;
            // CW: CORE WORLDBUILDING;
            // CW: CORE MECHANICS:
            //      ZIEL: ORTE DURCHSPIELEN ("EROBERN");
            //      MON GANGS, JE 3 MONS - TEAM SYNERGY!;
            //      KAMPFSYSTEM TUTORIAL;
            //      STARTER MON AUSWÄHLEN (1 von 3? 1 von 8 (genos)? 1 von 9 (typings)?);
            // WELT / ORTE (LISTE, AUSWAHL): DESERT (EARTH), FOREST (BIO), MARSH (TOXIN), RIVER (WATER), POLAR (ICE), VOLCANO (FIRE), SKY (AIR), POWER PLANT (LIGHTNING), NIGHTLANDS (SHADOW);
            // orte haben SIMPLE GRAFIK: (string "" ZEICHENSYMBOLE + FARBE);
            // orte haben "NPC" (LISTE, ITEMS) MIT VERSCHIEDENEN FUNKTIONEN (LISTE, RANDOM PLATZIEREN NACH RUNDE): HEALERS, SALESMEN, THIEFS;
            // orte haben bestimmte MONS (LISTE, RANDOM AUSWAHL PRO RUNDE);

TAG 3
C // ATTACKEN
            //CHECK     initialisiere ATTACKEN;
            //CHECK     ELEMENTAL TYPING: NEUTRAL, EARTH, BIO, TOXIN, WATER, ICE, FIRE, AIR, LIGHTNING, SHADOW;
            //CHECK     CATEGORY: PHYSICAL, PSYCHIC, STATUS;
            //CHECK     POWER: BASE DAMAGE;
            // TYPE EFFECTIVEVENSS (+25% damage super effecitve / -25% damage not very effective) 
            // if ATTACK TYPE = MON TYPE: SAME TYPE ATTACK BONUS +10%
            // COST: STAMINA/PSYMINA;
            // EFFECT: ADDITIONAL EFFECTS;
            +// ATTACH ATTACK LEARNSET TO MONS;

TAG 4 + 5
D // KAMPFSYSTEM
            // KAMPFBEGINN;
            // MON-POSITIONEN AUSWÄHLEN: 1, 2, 3;
            // DISPLAY (string "?" MIT FARBE): MON: HP - GREEN;
            // DISPLAY (string "?" MIT FARBE): STAMINA - BLUE;
            // DISPLAY (string "?" MIT FARBE): PSYMINA - PURPLE; 
            // DISPLAY (string "?" MIT FARBE): EFFECT (POISON, PARALYZED, BURNED, CURSED...);
            // DISPLAY (string "+ = buff; - = debuff" MIT FARBE): BUFFS / DEBUFFS;
            // DISPLAY (string "?" MIT FARBE): ELEMENTAL TYPING, CLASS;
            // DISPLAY: ROUND COUNTER;
            // KAMPFSYSTEM: ATTACKS;
            // KAMPFSYSTEM: EFFECTS MONS;
            // KAMPFSYSTEM: FAINTS;
            // USER “INTERFACE”: ATTACKS MENU / ITEMS / ORGANISATION(MON INFO, POSITIONEN) / RUN;
            // USER “INTERFACE”: ATTACKS MENU: 4 ATTACKS
            // USER “INTERFACE”: AUSWAHL;
            // WHEN ATTACK: - STAMINA/ - PSYMINA;
            // WHEN ATTACKED: - HP, EFFECTS;
            // USING ITEMS
[ADDED AFTER GREEN LIGHT]    // MONS KÖNNEN REKRUTIERT WERDEN MIT ITEMS (DRINKS ERHÖHEN WAHRSCHEINLICHKEIT ZUR REKRUTIERUNG)
[ADDED AFTER GREEN LIGHT]    // REKRUTIERUNG AM SCHLUSS DES GEWONNENEN KAMPFS

E // GAMEPLAY TESTEN / DEBUGGEN


// Powershell vom richtigen Projektordner öffnen

git status  //Hiermit können wir den Status des Repos sehen

git add .  //Füght die Elemente hinzu die commited werden sollen

git commit //Macht ein Commit

git push //Ladet den Commit ins Online Repos hoch

*/
