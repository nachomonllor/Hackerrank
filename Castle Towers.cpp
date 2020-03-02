#include <bits/stdc++.h>
using namespace std;
int castleTowers(int n, vector <int> ar) {
	int max = -1;
	int cont_max =0;
	for(int i = 0; i < n; i++) {
		if(ar[i] > max) {
			max = ar[i];
			cont_max=1;
		}else if(ar[i] == max) {
			cont_max++;
		}
	}
	return cont_max;
}

int main() {
	int n;
	cin >> n;
	vector<int> ar(n);
	for(int ar_i = 0; ar_i < n; ar_i++){
		cin >> ar[ar_i];
	}
	int result = castleTowers(n, ar);
	cout << result << endl;
	return 0;
}
