# DoesItHavePermutation
The project success confirms that two different parameters contain permutation of one another.

The defined problem is as follows and consists of 3 separate situations. Each case was created as a unit test and started to be developed at this stage.

Situation:
Logically check that one of the text (string) permutations that come with two separate parameters match the other parameter.

Sample cases:
"baba", "abab" => true
"baba", "abc" => false
"lds", "loodos" => true

Solution Description:
There is a loop inside the GetEveryPermutation function and this loop obtains the permutation value up to the maximum length of the parameter.

The permutation class consists of 2 separate functions. the X power of the length of the text gives the maximum number of permutations.

The other function uses the modulo operator to change the order of the incoming characters and adds the new value to the list.

After all these processes, the lists are checked to see if they contain parameters.