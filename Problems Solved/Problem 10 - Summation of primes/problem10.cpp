#include <iostream>

using namespace std;

long long int ans = 0;

bool isPrime(long long int num){
    bool ans = true;
    for(int i = 2; i <= num/2; i++) {
        if(num%i == 0) {
            ans = false;
            break;
        }
    }
    return ans;
}

int main(){

    for(long long int i = 2; i < 2e6+1; i++){
        if(isPrime(i)){
            ans += i;
        }
    }

    printf("%lld", ans);

    return 0;
}