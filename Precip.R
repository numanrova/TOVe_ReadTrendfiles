#' @export
  
  
 -getGrassMonthlyPrecip <- function(points, start_time, end_time, where=null, type=c("sum", "avg")){
 +getGrassMonthlyPrecip <- function(points, start_time, end_time, where=NULL, type=c("sum", "avg")){
  
    #Check that is is run on NINSRV16
    host<-NULL
