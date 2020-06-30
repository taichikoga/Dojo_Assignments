class Person {
    constructor(name) {
    this.name = name;
    this.firstChild = null;
    }
}

class FamList {
    constructor() {
    this.headOfHousehold = null;
    }

    getYou() {
    let runner = this.headOfHousehold;

    while (runner.firstChild !== null) {
    runner = runner.firstChild;
    }

    console.log(runner);
    }
}

const greatGrandpa = new Person("Great Grandpa");
greatGrandpa.firstChild = new Person("Grandpa");
greatGrandpa.firstChild.firstChild = new Person("Dad");
greatGrandpa.firstChild.firstChild.firstChild = new Person("You");
const you = greatGrandpa.firstChild.firstChild.firstChild;

const famList = new FamList();
famList.headOfHousehold = greatGrandpa;

famList.getYou();

/* 
1. Mon
- isEmpty
- insertAtBack
- seedFromArr
*/

class Node {
    constructor(data) {
    this.data = data;
    this.next = null;
    }
}

class SList {
    constructor() {
    this.head = null;
    }

    isEmpty() {
    return this.head === null;
    }

    insertAtBack(val) {
    const newNode = new Node(val);

    if (this.isEmpty()) {
        this.head = newNode;
        return;
    }

    let runner = this.head;

    while (runner.next !== null) {
        runner = runner.next;
    }
    runner.next = newNode;
    }

    seedFromArr(arr) {
    for (const elem of arr) {
        this.insertAtBack(elem);
    }
    }

    display() {
    let str = "";

    let runner = this.head;

    while (runner !== null) {
        str += runner.data;

        // add ", " if not last node
        if (runner.next !== null) {
        str += ", ";
        }
        runner = runner.next;
    }
    console.log(str);
    return str;
    }
}

const linkedList = new SList();
  // linkedList.insertAtBack(1);
  // linkedList.insertAtBack(2);
  // linkedList.insertAtBack(3);
linkedList.seedFromArr([1, 2, 3, 5, 6, 7, 8, 9, 10]);
linkedList.display();