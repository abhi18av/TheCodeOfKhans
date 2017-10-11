<#This script is analog of bash example from http://www.learnshell.org/en/Loops - for loop #>
$arr = 3,4,5,6,7,8
for($i = 0; $i -lt $arr.Length; $i++){
    $arr[$i]
}