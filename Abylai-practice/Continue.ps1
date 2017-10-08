<#This script is analog of bash example from http://www.learnshell.org/en/Loops - "break" and "continue" statements #>
<# print out only odd numbers from 0 to 10 #>
$var = 0
while($var -lt 10){ <# while $var less than 10 #>
    $var++
    if($var % 2 -eq 0){ <#check if $var is odd#>
        continue
    }
    echo $var
}