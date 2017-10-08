<#This scrit is analog of bash example from http://www.learnshell.org/en/Arrays #>
$my_array = 'apple', 'banana', 'Fruit Basket', 'orange' <#array that contains 4 string values #>
$my_array <#array output#>
Write-Output "    "
Write-Output "Type of array"
Write-Output $my_array.GetType() <#determinate type of array#>
Write-Output "    "
Write-Output "invoke the second item in array"
$my_array[1] <#second item in array#>
$my_array[2] = 'fruit'<#replace 2nd item in array#>
Write-Output "    "
$my_array <#5 items array output#>
