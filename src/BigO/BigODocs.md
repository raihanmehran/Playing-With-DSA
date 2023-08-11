# Big O
Big O is comparing Code1 and Code2 which solves exactly the same problem mathematically about how effienct they run.

## Time Complexity
## Space Complexity

## Big O Notations
- O(n)
  - Rule for simplification
    - Drop Constants
      ```java
      public static void printItems(int n){
        for(int i=0; i<n; i++){
          System.out.println(i);
        }

        for(int j=0; j<n; j++){
          System.out.println(j);
        }
      }
      ```
      In the code we have n + n operations, so n + n = 2n and we might think that this is O(2n) but according to the simplification rule we have to drop the constant and say it is O(n).
      
- O(n^2)
  ```java
      public static void printItems(int n){
        for(int i=0; i<n; i++){
          for(int j=0; j<n; j++){
            System.out.println(i + " " +j);
          }
        }        
      }
  ```
  The above code is n * n , and n * n = n^2, so we can say it's O(n^2).
  But it is important to keep in mind that this type of code is not efficient, and if there is a way to rewrite the code it will be great gain in performance.

  - Rule for simplification
    - Drop Non-Dominants
      ```java
      public static void printItems(int n){
        for(int i=0; i<n; i++){
          for(int j=0; j<n; j++){
            System.out.println(i + " " +j);
          }
        }

        for(int j=0; j<n; j++){
          System.out.println(j);
        }        
      }
      ```
      In the above code the first nested loop is O(n^2) and the second loop is O(n) so O(n^2) + O(n) = O(n^2 + n). But according to rule of drop non-dominant the n will be dropped because it's not dominant. And it will be O(n^2) only.
        
- O(1)
  ```java
      public static int addItems(int n){
        return n + n       
      }
  ```
  It's O(1), and what if `return n+n+n`, I mean right now it's two operations and we could call it O(2), but no we still call it O(1) because as the n grows the number of operations stay the same.
  It's the most efficient Big O, If we can do something in O(1), then it's our code it more efficient.
  
- O(n)
