class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        map<int, int> umap;
        int difference;

        for(int i = 0; i < nums.size(); i++ ){
            difference = target - nums.at(i);
            if(umap.find(difference) != umap.end()) {
                vector<int> v{umap[difference], i};
                return v;
            } else {
                umap[nums.at(i)] = i;
            }
        }

        return vector<int> {};
    }
};