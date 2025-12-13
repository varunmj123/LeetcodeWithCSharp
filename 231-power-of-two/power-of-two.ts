function isPowerOfTwo(n: number): boolean {
    let remainder: number = n%2;
    if(n == 1){
        return true;
    }
    else if(n <= 0){
        return false;
    }
    else if(remainder == 0){
        return isPowerOfTwo(n/2);
    }
    else if(remainder > 0){
        return false;
    }

};



// If it is dvisible by 2, and no remainder keep going
// If there is remainder then return false
// Exit when not clling itself