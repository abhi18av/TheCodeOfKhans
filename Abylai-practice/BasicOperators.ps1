<#This scrit is analog of bash example from http://www.learnshell.org/en/Basic_Operators" #>
$A = 3 <#create variable with value 3#>
$B = 100*$A + 5
$B <#call result#>

<#Exercise#>
<#calculate to total cost (variable TOTAL) of a fruit basket#>
$COST_PINEAPPLE=50
$COST_BANANA=4
$COST_WATERMELON=23
$COST_BASKET=1
$TOTAL=$COST_BASKET+$COST_WATERMELON+$COST_BANANA+$COST_PINEAPPLE
echo "Total Cost is $TOTAL"