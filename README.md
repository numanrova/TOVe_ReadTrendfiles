# TOVe_ReadTrendfiles
Script for reading trendfiles in a folder into one single text file.

Files created with TRend analysis and Indices for Monitoring data 

Syntax of .out files
 TRIM 3.54 :  TRend analysis and Indices for Monitoring data 
 STATISTICS NETHERLANDS 

 Date/Time: 26.01.2016 15:51:01

 Title :          _14

 Comment: 1840_14

 The following  5 variables have been read from file: 
 C:\BirdSTAT2015\TrimRes\1840_14.poi

 1. Site             number of values:    90
 2. Time             number of values:     8
 3. Count            missing =         -1
 4. weight 
 5. COVA             number of values:  1

 Number of sites without positive counts (removed)       3

 Number of observed zero counts         376
 Number of observed positive counts     151
 Total number of observed counts        527
 Number of missing counts               193
 Total number of counts                 720

 Total count                          246.0

 Sites containing more than 10% of the total count 
   Site Number  Observed Total    %   
    < none >

 Time Point Averages 
                                              Weighted  Weighted
   TimePoint  Observations  Average   Index   Average   Index  
    2008              46       0.46    1.00      0.46    1.00
    2009              50       0.22    0.48      0.22    0.48
    2010              60       0.78    1.72      0.78    1.72
    2011              71       0.59    1.30      0.59    1.30
    2012              75       0.37    0.82      0.37    0.82
    2013              74       0.51    1.12      0.51    1.12
    2014              74       0.35    0.77      0.35    0.77
    2015              77       0.43    0.94      0.43    0.94

 RESULTS FOR MODEL: Linear Trend
 --------------------------------
   Effects of covariate(s)
    COVA
   Changes in Slope at Timepoints
   2008  2009  2010  2011  2012  2013  2014 

 WEIGHTING = On

 ESTIMATION METHOD = Generalised Estimating Equations

 Warning: Covariate   1 has only one value 
 This Covariate is removed 


  Total time used:  3.51 seconds

  Estimated Overdispersion     =  1.339
  Estimated Serial Correlation = -0.153

 GOODNESS OF FIT
  Chi-square                575.66, df    430, p 0.0000
  Likelihood Ratio          473.18, df    430, p 0.0737
  AIC (up to a constant)   -386.82

 WALD-TEST FOR SIGNIFICANCE OF CHANGES IN SLOPE 
 Changepoint    Wald-Test  df   p  
   2008             1.29    1  0.2566
   2009             3.76    1  0.0526
   2010             4.46    1  0.0347
   2011             0.31    1  0.5776
   2012             1.32    1  0.2503
   2013             0.80    1  0.3698
   2014             0.49    1  0.4839

 PARAMETER ESTIMATES 

 Slope for Time Intervals
 from upto   Additive  std.err.    Multiplicative   std.err.
