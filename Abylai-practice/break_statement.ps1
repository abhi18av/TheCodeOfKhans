<#This script is analog of bash example from http://www.learnshell.org/en/Loops - "break" and "continue" statements #> 
$COUNT = 0
while($true){
    echo "Value of COUNT is: $COUNT" <#Prints out from 0-4 #>
    $COUNT++ 
    if($COUNT -eq 5){ <#breaks the loop when $COUNT equals 5#>
        break
    }
}  