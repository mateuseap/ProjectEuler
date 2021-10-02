using System;

class fibonacci{
    static ulong fib(ulong n){
        ulong []f = new ulong[n+2];
        ulong ans = 2;

        f[0] = 1;
        f[1] = 2;
            
        for(ulong i = 2; i <= n; i++){
            f[i] = f[i-1]+f[i-2];
            if(f[i] > 4000000){
                break;
            }else if(f[i]%2 != 0){
                ans += f[i];
            }
        }
        
        return ans;
    }
     
    public static void Main(){
        Console.WriteLine(fib(100));
    }
}