<#This script is analog of bash example from http://www.learnshell.org/en/Loops - while loop #>
$COUNT = 4
while($COUNT -ne 0){ <# test condition. Output current $COUNT and decrementing it #>
    "Value of count is: $COUNT"
    $COUNT--
}