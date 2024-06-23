//*****************************************************************************
//** 1438. Longest Continuous Subarray With Absolute Diff Less Than or Equal **
//** to Limit leetcode                                                       **
//**                                                                         **
//**                                                                         **
//**                                                                         **
//**                                                                         **
//**                                                                         **
//*****************************************************************************

int longestSubarray(int* nums, int numsSize, int limit){
    int retNum = 0;
    int min = 0;
    int max = 0;
    for(int i = 0; i < numsSize; ++i){
         min = nums[i];
         max = nums[i];
        for(int j = i; j < numsSize; ++j){
            min = nums[j] < min ? nums[j] : min;
            max = nums[j] > max ? nums[j] : max;
            if((max - min) <= limit){
                retNum = (j - i) < retNum ? retNum : (j - i);
            }else{
                break;
            }
        }
        if (retNum >= numsSize - 1 - i) {
            break;
        }
    }
    return retNum + 1;
}