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

const ninja1 = new Ninja("Hyabusa", 100);
// console.log(ninja1);
ninja1.sayName();
ninja1.showStats();
ninja1.addSake();