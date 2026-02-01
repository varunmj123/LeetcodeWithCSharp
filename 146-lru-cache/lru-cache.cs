public class ListNode{
    public int val;
    public ListNode previous;
    public ListNode next;
    public int key;

    public ListNode(int key = 0, int val = 0,  ListNode next = null, ListNode previous = null){
        this.val = val;
        this.next = next;
        this.previous = previous;
        this.key = key;
    }
}



public class LRUCache {
    // To find a node
    private Dictionary<int, ListNode> lruCache;
    private int size;
    // Most recently used node on the right side
    private ListNode left;
    // Least recently used node on the left side
    private ListNode right; 
    public LRUCache(int capacity) {
        size = capacity;
        lruCache = new Dictionary<int, ListNode>();
        left = new ListNode();
        right = new ListNode(); 
        left.next = right;
        right.previous = left;
    }

    public int Get(int key) {
        if(lruCache.ContainsKey(key)){
            ListNode node = lruCache[key];
            Remove(node);
            Insert(node);
            return node.val;
        }
        return -1;
    }


    public void Put(int key, int value) {
        if(lruCache.ContainsKey(key)){
            ListNode node = lruCache[key];
            node.val = value;
            Remove(node);
            Insert(node);
        }
        else{
            ListNode newNode = new ListNode(key, value);
            lruCache[key] = newNode;
            Insert(newNode);
            if(lruCache.Count > size){
                ListNode lru = left.next;
                Remove(lru);
                lruCache.Remove(lru.key);
            }
        }

        
    }

    // Insert a node  before the right node (our most recently used)
    public void Insert(ListNode node){
        ListNode beforeRight = right.previous;
        beforeRight.next = node;
        node.previous = beforeRight;
        node.next = right;
        right.previous = node;
    }

    // Unlink a node form the list by connecting its previous and next nodes
    public void Remove(ListNode node){
        ListNode tempPrev = node.previous;
        ListNode tempNext = node.next;
        // the previouss' next objext should point to next of node
        tempPrev.next = tempNext;
        // the nexts' previous objext should point to previous of node
        tempNext.previous = tempPrev;
    }
    

}


/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */