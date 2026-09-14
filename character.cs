using System;

namespace GameEncapsulationDemo
{
    public class Character
    {
        // Atribut Instance
        public string characterID = "";
        public string characterName = "";
        public string characterClass = "";
        public float health;
        public int level;

        // --- ATRIBUT CLASS (STATIC) ---
        private static int totalCharacterCount = 0;

        // --- METHOD CLASS (STATIC) ---
        public static int GetTotalCharacterCount()
        {
            return totalCharacterCount;
        }

        // Method
        public void Start()
        {
            level = 1;
            health = 100;
            Console.WriteLine($"{characterName} (level {level}) memulai petualangan!");
        }

        private void LevelUp()
        {
            level++;
            Console.WriteLine($"{characterName} naik level! Level sekarang: {level}");
        }

        public void TakeDamage(float dmg)
        {
            health -= dmg;
            Console.WriteLine($"{characterName} menerima {dmg} damage. Health tersisa: {health}");
            if (health <= 0)
            {
                Console.WriteLine($"{characterName} telah gugur!");
            }
        }

        public void Heal(float healAmt)
        {
            health += healAmt;
            Console.WriteLine($"{characterName} sembuh sebesar {healAmt}. Health sekarang: {health}");
        }

        public void Showstats()
        {
            Console.WriteLine("=== STATS KARAKTER ===");
            Console.WriteLine($"ID      : {characterID}");
            Console.WriteLine($"Nama    : {characterName}");
            Console.WriteLine($"Class   : {characterClass}");
            Console.WriteLine($"Level   : {level}");
            Console.WriteLine($"Health  : {health}");
            Console.WriteLine("======================");
        }

        // --- KONSTRUKTOR ---

        // 1. Konstruktor Default
        public Character()
        {
            characterID = "UNKNOWN";
            characterName = "Hero";
            characterClass = "Adventurer";
            health = 100;
            level = 1;
            totalCharacterCount++; // Menambah jumlah total karakter
            Console.WriteLine("Objek Character dibuat dengan Konstruktor Default.");
        }

        // 2. Konstruktor Berparameter (2 parameter)
        public Character(string id, string name)
        {
            characterID = id;
            characterName = name;
            characterClass = "Adventurer";
            health = 100;
            level = 1;
            totalCharacterCount++; // Menambah jumlah total karakter
            Console.WriteLine($"Objek Character dibuat dengan Konstruktor Berparameter (ID & Nama).");
        }

        // 3. Konstruktor Berparameter (3 parameter)
        public Character(string id, string name, string classType)
        {
            characterID = id;
            characterName = name;
            characterClass = classType;
            health = 100;
            level = 1;
            totalCharacterCount++; // Menambah jumlah total karakter
            Console.WriteLine($"Objek Character dibuat dengan Konstruktor Berparameter (ID, Nama, & Class).");
        }
    }
}