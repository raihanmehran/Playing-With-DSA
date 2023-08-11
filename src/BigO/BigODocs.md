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
  
- O(n)
- O(n)
