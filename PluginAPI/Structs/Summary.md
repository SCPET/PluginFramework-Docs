# Summary
The Summary struct provides information on the end of a round.

## `RoundEndReason` EndingReason
Get: Yes  
Set: No  
Specifies the reason why the round ended.

## `int` TotalEscapes
Get: Yes  
Set: No  
Specifies how many players escaped during this round.

## `int` TotalDeaths
Get: Yes  
Set: No  
Specifies how many players died during this round.

## `DateTime` StartTime
Get: Yes  
Set: No  
Specifies the time that the round started.

## `DateTime` EndTime
Get: Yes  
Set: No  
Specifies the time that the round ended.

## `TimeSpan` RoundLength
Get: Yes  
Set: No  
Specifies the length of the round. Equivalent to `(EndTime - StartTime)`.