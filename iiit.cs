
body {
    background-image: url(bkg2.jpg);
   color: aliceblue;
   font-family: "Poppins", sans-serif;
   background-size: cover;
   height: 50%;
   background-repeat: no-repeat;
   background-color: rgb(0, 0, 0);
   
 }

nav {
    display: flex;
    align-items: center;
    justify-content: space-between;
    
  }
  .left
  {  margin-left: 45px;
    font-size: 20px;
  }
  .right {
    align-self: flex-end;
 
  }
  .right ul {
    display: flex;
    flex-direction: row;
    
  }
  li {
    margin: 20px;
  }
  .right ul li a {
    color: rgb(248, 248, 248);
    text-decoration: none;
    font-size: medium;
  }
  .right ul li a:hover {
  
    text-decoration: underline;
    text-decoration-color: #ff771d;
    font-size: medium;
  }
  #vid{
    color: rgb(197, 84, 3);
    font-weight: 600;
  }

.top{
    display: flex;
    justify-content: space-between;
   
    
}
.left1{
  color:aliceblue;
  
  margin-top: 20px;
  font-size: xx-large;
  margin-left: 30%;
  
}
.left1:hover{
    text-decoration: underline;
    text-decoration-color: #ff771d ;
}
.right1{
    margin-right: 50px;
    margin-top: 20px;
  
  
}
#im{
    width: 25px;
    height: 25px;;
}
img{
    width: fit;
    height:200px;
}
.nit{
    display: grid;
    grid-template-columns: auto auto auto;
    padding: 10px;
    
    
}
.nit_name{
    background-color:rgb(205, 196, 180);
    border: 1px solid rgba(13, 124, 132, 0.8);
    padding: 15px;
    font-size: 20px;
    text-align: center;
    margin: 10px 10px;
    border-radius: 15px;
    box-shadow: 2px 2px  10px rgb(31, 179, 190);
    
}
a{
    text-decoration: none;
    color: rgb(61, 61, 61);
    font-weight: 500;
}

.nit_name a:hover{
    text-decoration: underline;
    
}
