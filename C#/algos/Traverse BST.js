/* 
  1. Mon
    1. isEmpty
    2. min (with & without recursion)
    3. max (with & without recursion)

  2. Tue
    1. contains (with & without recursion)

  3. Wed
    1. insert (with & without recursion)
        - insert the new value in the appropriate place in the tree
    2. range (Range is max minus min. What if tree is empty?)\
    Bonus: full (recursive: isFull if every node other than the leaves has two children)

  4. Thur (Recursive Traversal Order)
    1. console.log each node's val in depth first search (DFS) Preorder: (Parent, Left, Right)
        - on fullBstTest, it should log in this order: 25, 15, 10, 4, 12, 22, 18, 24, 50, 35, 31, 44, 70, 66, 90
    2. console.log each node's val in depth first search (DFS) Inorder: (Left, Parent, Right)
        - on fullBstTest, it should log in this order: 4, 10, 12, 15, 18, 22, 24, 25, 31, 35, 44, 50, 66, 70, 90
    3. console.log each node's val in depth first search (DFS) Postorder: (Left, Right, Parent)
        - on fullBstTest, it should log in this order: 4, 12, 10, 18, 24, 22, 15, 31, 44, 35, 66, 90, 70, 50, 25
*/

class Node {
  constructor(val) {
    this.val = val;
    this.left = null;
    this.right = null;
  }
}

class BinarySearchTree {
  constructor() {
    this.root = null;
  }

  // Time: O(1) constant
  // Space: O(1)
  isEmpty() {
    return this.root === null;
  }

  // show without params first, so adding param can be a lesson for min of right sub tree: bst.min(bst.root.right)
  // Time: O(h) linear, h = height of left sub tree starting from current node
  // Space: O(1)
  min(current = this.root) {
    if (current === null) {
      return null;
    }

    while (current.left) {
      current = current.left;
    }
    return current.val;
  }

  // Time: O(h) linear, h = height of left sub tree starting from current node
  // Space: O(1)
  minRecursive(current = this.root) {
    if (current === null) {
      return null;
    }

    if (current.left === null) {
      return current.val;
    }
    return this.minRecursive(current.left);
  }

  // show without params first, so adding param can be a lesson for max of left sub tree: bst.max(bst.root.left)
  // Time: O(h) linear, h = height of right sub tree starting from current node
  // Space: O(1)
  max(current = this.root) {
    if (current === null) {
      return null;
    }

    while (current.right) {
      current = current.right;
    }
    return current.val;
  }

  // Time: O(h) linear, h = height of right sub tree starting from current node
  // Space: O(1)
  maxRecursive(current = this.root) {
    if (current === null) {
      return null;
    }

    if (current.right === null) {
      return current.val;
    }
    return this.minRecursive(current.right);
  }

  // Time: O(h) linear, h = height of tree
  // Space: O(1)
  contains(searchVal) {
    let current = this.root;

    while (current) {
      if (current.val === searchVal) {
        return true;
      }

      if (searchVal < current.val) {
        current = current.left;
      } else {
        current = current.right;
      }
    }
    return false;
  }

  // Time: O(h) linear, h = height of tree
  // Space: O(1)
  containsRecursive(searchVal, current = this.root) {
    if (current === null) {
      return false;
    }

    if (current.val === searchVal) {
      return true;
    }

    if (searchVal < current.val) {
      return this.containsRecursive(searchVal, current.left);
    }

    if (searchVal > current.val) {
      return this.containsRecursive(searchVal, current.right);
    }
  }

  // Time: O(h) linear, h = height of tree because we might be adding at bottom
  // Space: O(1)
  insert(newVal) {
    const node = new Node(newVal);

    if (this.isEmpty()) {
      this.root = node;
    } else {
      let current = this.root;

      while (true) {
        if (newVal <= current.val) {
          if (!current.left) {
            current.left = node;
            break;
          } else {
            current = current.left;
          }
        } else {
          // newVal is greater than current.val
          if (!current.right) {
            current.right = node;
            break;
          } else {
            current = current.right;
          }
        }
      }
    }
    return this;
  }

  // Time: O(h) linear, h = height of tree
  // Space: O(1)
  insertRecursive(newVal, curr = this.root) {
    if (this.isEmpty()) {
      this.root = new Node(newVal);
      return this;
    }

    if (newVal > curr.val) {
      if (curr.right === null) {
        curr.right = new Node(newVal);
        return this;
      }
      return this.insertRecursive(newVal, curr.right);
    } else {
      if (curr.left === null) {
        curr.left = new Node(newVal);
        return this;
      }
      return this.insertRecursive(newVal, curr.left);
    }
  }

  // Time: O(rightHeight + leftHeight) -> still linear so simplify to O(h)
  // Space: O(1)
  range(startNode = this.root) {
    if (!startNode) {
      return null;
    }
    return this.max(startNode) - this.min(startNode);
  }

  isFull(node = this.root) {
    // if empty, or node is null
    if (!node) {
      return false;
    }

    // if leaf node
    if (!node.left && !node.right) {
      return true;
    }

    if (node.left && node.right) {
      return this.isFull(node.left) && this.isFull(node.right);
    }

    return false;
  }

// 4. Thur (Recursive Traversal Order)
// 1. console.log each node's val in depth first search (DFS) Preorder: (Parent, Left, Right)
//     - on fullBstTest, it should log in this order: 25, 15, 10, 4, 12, 22, 18, 24, 50, 35, 31, 44, 70, 66, 90
// 2. console.log each node's val in depth first search (DFS) Inorder: (Left, Parent, Right)
//     - on fullBstTest, it should log in this order: 4, 10, 12, 15, 18, 22, 24, 25, 31, 35, 44, 50, 66, 70, 90
// 3. console.log each node's val in depth first search (DFS) Postorder: (Left, Right, Parent)
//     - on fullBstTest, it should log in this order: 4, 12, 10, 18, 24, 22, 15, 31, 44, 35, 66, 90, 70, 50, 25

  depthFirstSearch(current = this.root) {
    if (current === null) {
      return null;
    }

    if (current.left === null) {
      return current.val;
    }
    return this.depthFirstSearch(current.left);
  }

      // (1) visit the node of the tree, (2) traverse the left, (3) then traverse the right 
    // create a varaible to store the values we've visted, andd return it in the end 
    //store the root of the BST in a variable called current

    //generate a helper function to accept a node
    //push the value of the node to the variable that store the values until the end
    //if the node has a left property, call the helper function (recursively) with the left property on the node
    //if the node has a right property, call the helper function (recursively) with the right property on the node
    //return the array of values which we visited  

    DFSPreOrder() {
      var data = [];

      function traverse(node) { //helper function 
          data.push(node.data);
          if (node.left) traverse(node.left);
          if (node.right) traverse(node.right);
      }
      traverse(this.root);
      return data;
  }
// 2. console.log each node's val in depth first search (DFS) Inorder: (Left, Parent, Right)
//     - on fullBstTest, it should log in this order: 4, 10, 12, 15, 18, 22, 24, 25, 31, 35, 44, 50, 66, 70, 90
    DFSInOrder() {
      var data = [];

      function traverse(node) { //helper function 
        if (node.left) traverse(node.left);
        if (node.right) traverse(node.right);
        data.push(node.data);
      }
      traverse(this.root);
      return data;
    }

}

const emptyTree = new BinarySearchTree();
const oneNodeTree = new BinarySearchTree();
oneNodeTree.root = new Node(10);

/* twoLevelTree 
        root
        10
      /   \
    5     15
*/
const twoLevelTree = new BinarySearchTree();
twoLevelTree.root = new Node(10);
twoLevelTree.root.left = new Node(5);
twoLevelTree.root.right = new Node(15);

/* fullTree
                    root
                <-- 25 -->
              /            \
            15             50
          /    \         /    \
        10     22      35     70
      /   \   /  \    /  \   /  \
    4    12  18  24  31  44 66  90
*/

const fullTree = new BinarySearchTree();
fullTree
  .insert(25)
  .insert(15)
  .insert(10)
  .insert(22)
  .insert(4)
  .insert(12)
  .insert(18)
  .insert(24)
  .insert(50)
  .insert(35)
  .insert(70)
  .insert(31)
  .insert(44)
  .insert(66)
  .insert(90);

  DFSPreOrder(fullTree)
