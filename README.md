# TOVe_ReadTrendfiles
Script for reading trendfiles in a folder into one single text file

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
 2008 2009   -0.5159    0.4548          0.5969       0.2715
 2009 2010    1.0281    0.4008          2.7958       1.1207
 2010 2011   -0.1516    0.2752          0.8593       0.2364
 2011 2012   -0.4332    0.3073          0.6484       0.1993
 2012 2013    0.2121    0.3137          1.2363       0.3879
 2013 2014   -0.2763    0.3188          0.7586       0.2418
 2014 2015    0.1331    0.3290          1.1424       0.3759

 Time INDICES
  Time     Model     std.err.     Imputed    std.err.
  2008     1                       1
  2009     0.5969     0.2715       0.5777     0.2693
  2010     1.6689     0.5293       1.6615     0.5299
  2011     1.4341     0.4547       1.4399     0.4579
  2012     0.9299     0.3219       0.9277     0.3228
  2013     1.1497     0.3757       1.1720     0.3819
  2014     0.8721     0.3061       0.8742     0.3078
  2015     0.9963     0.3336       1.0039     0.3364

 TIME TOTALS
  Time      Model    std.err.     Imputed    std.err.
  2008         43         11           43         11
  2009         26          9           25          9
  2010         72         13           72         13
  2011         62         12           62         12
  2012         40          9           40          9
  2013         50         10           51         10
  2014         38          9           38          9
  2015         43          9           43          9

 OVERALL SLOPE MODEL: Uncertain
  Additive      std.err.   Multiplicative  std.err.
    0.0038       0.0379         1.0038      0.0380

 OVERALL SLOPE MODEL (with intercept) FOR TIME INTERVALS
 from upto   Additive  std.err.    Multiplicative   std.err.
 2008 2015    0.0038    0.0379          1.0038       0.0380

 OVERALL SLOPE IMPUTED (recommended): Uncertain
  Additive      std.err.   Multiplicative  std.err.
    0.0073       0.0383         1.0073      0.0386

 OVERALL SLOPE IMPUTED (with intercept) FOR TIME INTERVALS
 from upto   Additive  std.err.    Multiplicative   std.err.
 2008 2015    0.0073    0.0383          1.0073       0.0386

 Fitted and imputed values written to file: C:\BirdSTAT2015\TrimRes\1840_14.F1
 Slopes and indices written to file: C:\BirdSTAT2015\TrimRes\1840_14.S1
