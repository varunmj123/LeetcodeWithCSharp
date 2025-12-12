function twoSum(nums: number[], target: number): number[] {
    // This will hold the number : index pair
    const dict = new Map<number, number>();

    for (let i = 0; i < nums.length; i++) {
        const complement = target - nums[i];

        if (dict.has(complement)) {
            return [i, dict.get(complement)!];
        }

        // Put the number as key, and value as the index
        dict.set(nums[i], i);
    }

    return [];
}
