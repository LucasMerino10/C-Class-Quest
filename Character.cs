public class Character {
    public string name;
    private int lifePoints = 20;
    private int attackPoints;
    private int defensePoints;


    public Character(string name, int attackPoints, int defensePoints) {
        this.name = name;
        this.attackPoints = attackPoints;
        this.defensePoints = defensePoints;
    }

    public bool IsAlive() {
        return lifePoints > 0;
    }

    public void Attack(Character ennemy) {
        ennemy.lifePoints = ennemy.lifePoints - (attackPoints - ennemy.defensePoints);
        Console.WriteLine(name + " hit " + ennemy.name + " for " + (attackPoints - ennemy.defensePoints) + " damages");
        Console.WriteLine(ennemy.name + "'s life is now " + ennemy.lifePoints);
    }

}