# File: C# Homework 16
# Name: William Chan
# Date: 23 August, 2020

1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.
	* ~
	* <<, >>
	* ^
	* &
	* |
2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valie
C# code.
	* 204 >> 2 
3. Explain in detail this code: bits & (1 << index);.
	* if(bits[index]==1), return true, else return false. 
4. Explain in detail this code: bits |= (1 << index);.
	* bits = bits | (1 << index), assign true value to bits[index]. return bits with bits[index] == 1.
5. Explain in detail this code: bits &= (1 << index);.
	* bits = bits & (1 << index), if bits[index] == 1, return a new bits with only bits[index] == 1 and all other indexers == 0, else, bits == 0;
6. How does C# interpret this? bool peek = bits[n];
	* if bits[n] == 1, return true; if bits[n] == 0, return false.  
7. How does C# interpret this? bits[n] = true;
	* bits[n] == 1.
8. How does C# interpret this? bits[n] ^= true;
	* bits[n] = bits[n] ^ 1; if bits[n] == 1, return 0; if bits[n] == 0, return 1;
9. Assume that users were assigned read, write, and execute permissions according to this scheme: read
= 1, write = 2, execute = 4. How would you interpret the following user permissions:
(a) permission = 0
	* no permission to read, write or execute
(b) permission = 1
	* only have permission to read
(c) permission = 2
	* only have permission tp write
(d) permission = 3
	* have permission to read and write but not execute
(e) permission = 4
	* only ahve permission to execute
(f) permission = 5
	* have permission to read and execute but not write
(g) permission = 6
	* have permission to write and execute but not read
(h) permission = 7
	* have permission to read, write and execute
10. Answer the previous question by converting the decimal permissions into binary permissions. What
does this tell you about using this shceme of permissions?
	* permission to read is determined by the first bit
	* permission to write is determined by the second bit
	* permission to executeis determined by the third bit