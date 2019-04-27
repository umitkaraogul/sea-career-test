function calcAvgHeight(data) {
  let average = 0;
  let counter = 0;
  for (var key in data) {
    average += data[key].height;
    counter += 1;
  }
  if (counter) return average / counter;

  return null;
}

var avgHeight = calcAvgHeight({
  Matt: { height: 174, weight: 69 },
  Jason: { height: 190, weight: 103 }
});
console.log(avgHeight);
//console.log(calcAvgHeight({}));
//console.log(calcAvgHeight(null));
//console.log(calcAvgHeight(undefined));
