static class Program {

    static void Main() {
        Character character1 = new Character("Superman", 5, 3);
        Character character2 = new Character("Homelander", 4, 2);

        while(character1.IsAlive() && character2.IsAlive()) {
            character1.Attack(character2);
            if (character2.IsAlive()) {
                character2.Attack(character1);
            }
        }

        if (character1.IsAlive()) {
            Console.WriteLine(character1.name + " defeated " + character2.name);
        } else {
            Console.WriteLine(character2.name + " defeated " + character1.name);
        }
    }
}
