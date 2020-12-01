public class Solution 
{
    public int[] SearchRange(int[] nums, int target) 
    {
        if(nums == null || nums.Length == 0) 
            return new int[] { -1, -1 };

        int leftIdx = FindFirstPosition(nums, target);
        int rightIdx = FindLastPosition(nums, target);

        return new int[] { leftIdx, rightIdx };
    }

    private int FindFirstPosition(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            if(nums[mid] == target) right = mid - 1; // 继续往左边区间查找 [left, mid - 1]
            else if (nums[mid] < target) left = mid + 1;
            else right = mid - 1;
        }

        // 跳出循环的后变为 [right, left] 需要 check left
        if(left != nums.Length && nums[left] == target) return left;

        return -1;
    }

    private int FindLastPosition(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            if(nums[mid] == target) left = mid + 1; // 继续往右边区间查找
            else if (nums[mid] < target) left = mid + 1;
            else right = mid - 1;            
        }

        if(right != -1 && nums[right] == target)  return right;
        
        return -1;
    }
}