

public class Solution {
    public Node CopyRandomList(Node head) {
        // Old Nodes: Copied Nodes
        var oldToCopy = new Dictionary<Node, Node>();
        // Iterate over inital list and add to dict of pairs : Old : New. They hold the same Node bascally but of diffrent ref
        Node curr = head;
        while(curr!= null){
            Node copy = new Node(curr.val);
            oldToCopy[curr] = copy;
            curr = curr.next;
        }
        // Reset curr back to head;
        curr = head;
        // Now we link the copied nodes together
        while(curr != null){
            Node copy = oldToCopy[curr];
            if(curr.next != null){
                copy.next = oldToCopy[curr.next];
            }
            else{
                copy.next = null;
            }

            if(curr.random != null){
                copy.random = oldToCopy[curr.random];
            }
            else{
                copy.random = null;
            }
            curr = curr.next;
        }
        if(head != null){
            return oldToCopy[head];
        }
        else{
            return null;
        }
    }
}
