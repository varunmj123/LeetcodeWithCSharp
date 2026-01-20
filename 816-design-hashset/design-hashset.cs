public class MyHashSet {
    private List<int> hashSet;
    public MyHashSet() {
        hashSet = new List<int>();
    }
    
    public void Add(int key) {
        bool keyExists = false;
        for(int i =0; i < hashSet.Count; i++){
            if(hashSet[i] == key){
                keyExists = true;
            }

        }
        if(!keyExists){
            hashSet.Add(key);
        }

    }
    
    public void Remove(int key) {
        hashSet.Remove(key);
    }
    
    public bool Contains(int key) {
        for(int i =0; i < hashSet.Count; i++){
            if(hashSet[i] == key){
                return true;
            }
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */