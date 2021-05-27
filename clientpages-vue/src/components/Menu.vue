<template>
  <header class="header">
          <img style="width:50px;" src="https://res.cloudinary.com/fissama/image/upload/v1622099299/fraud-alert_vdgsil.png" alt="icon"/>
    <nav class="nav">
      <ul class="nav-links">
        <li class="link">
          <router-link to="/">All products</router-link>
        </li>
        <li class="link">
          <router-link to="/Cleansers">Cleansers</router-link>
        </li>
        <li class="link">
          <router-link to="/SkinCare">SkinCare</router-link>
        </li>
        <li class="link">
          <router-link to="/BodyCare">BodyCare</router-link>
        </li>
        <li class="link">
          <router-link to="/Accessories">Accessories</router-link>
        </li>
      </ul>
    </nav>
    <slot></slot>
  </header>
</template>

<script>
export default {
};
</script>

<style scoped>
  .header {
    width: 100%;
    height: 70px;
    background-color: #333333;
    box-sizing: border-box;
    padding: .5em;
    display: flex;
    justify-content: center;
    align-items: center;
  }

  .nav {
    width: 950px;
    position: relative;
    left:80px;
  }

  .nav-links {
    width: 100%;
    display: flex;
    justify-content: flex-start;
  }

  .link {
    list-style: none;
    padding: 0 2em;
  }

  .link a:hover{
    color:red;
  }

  .link a {
    color: #fff;
    text-decoration: none;

  }
</style>
