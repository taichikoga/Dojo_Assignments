class Ninja {
    constructor (name, health, speed=3, strength=3) {
        this.name = name;
        this.health = health;
        this.speed = speed;
        this.strength = strength;
    }
    sayName() {
        console.log(this.name);
    }
    showStats() {
        console.log(this);
    }
    addSake() {
        this.health += 10;
        console.log('Health increased from ' + (this.health - 10) + ' to ' + this.health);
    }
}

class Sensei extends Ninja {
    constructor (name) {
        super (name, 200, 10, 10);
        this.wisdom = 10;
    }
    speakWisdom () {
        super.addSake();
        console.log("Laziness is the mother of all inventions");
    }
}

// example output
const superSensei = new Sensei("Master Splinter");
// console.log(superSensei)
superSensei.speakWisdom();
// -> "What one programmer can do in one month, two programmers can do in two months."
superSensei.showStats();
// -> "Name: Master Splinter, Health: 210, Speed: 10, Strength: 10"