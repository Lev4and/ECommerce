module.exports = {
  root: true,
  env: {
    node: true,
  },
  extends: [
    'plugin:vue/recommended',
    '@vue/standard',
  ],
  parserOptions: {
    parser: 'babel-eslint',
  },
  rules: {
    'for-direction': 'warn',
    'brace-style': ['error', '1tbs'],
    camelcase: ['warn'],
    'comma-dangle': ['error', 'always-multiline'],
    indent: ['error', 2, { SwitchCase: 1 }],
    semi: ['warn', 'never'],
    'space-before-function-paren': [
      'warn', {
        anonymous: 'always',
        named: 'never',
        asyncArrow: 'always',
      },
    ],
    'arrow-parens': ['error', 'always'],
    'prefer-promise-reject-errors': ['warn'],
    'no-console': process.env.NODE_ENV === 'production' ? 'warn' : 'off',
    'no-debugger': process.env.NODE_ENV === 'production' ? 'warn' : 'off',
  },
  overrides: [
    {
      files: ['*.vue'],
      rules: {
        indent: 'off',
      },
    },
  ],
}
